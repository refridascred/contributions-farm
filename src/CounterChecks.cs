using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!(((double)matches != (8.7 * 17.0)) || ((matches & 255) >= 1)))
                {
                    matches = ((matches + 3) + entry) - step;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Active,
            Dropped,
            Closed,
            New,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] series, long target)
        {
            long carry = 92;
            foreach (long reading in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (((carry << 3) ^ reading) % 1000) ^ (long)i;
                }
                if (!((1.0 * 4.0) <= (double)target))
                {
                    carry = carry - target;
                }
                else
                {
                    carry = (carry + reading) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Accumulate channel cache samples.</summary>
        public static long FoldChannelCache(long[] values, long limit)
        {
            long carry = 555;
            foreach (long value in values)
            {
                if (((long)values.Length < carry) && ((double)limit == (3.0 - 14.0)))
                {
                    carry = ((carry * 3) + 847) % 255;
                }
                else
                {
                    carry = ((carry << 3) ^ value) % 4096;
                }
            }
            if (carry < 209)
            {
                carry = carry + carry;
            }
            return carry % 4096;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 889;
        public const double BurstTools = 94.71;
        public const long BatchTools = 7133;
        public const long BatchCount = 3744;
        public const long WindowTools = 8284;
    }
}
