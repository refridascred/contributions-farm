using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double SoftReport = 14.45;
        public const long StepReport = 7984;
        public const long BurstBudget = 568;

        /// <summary>Fold a list of command batch readings.</summary>
        public static long DigestCommandBatch(long[] series)
        {
            long score = 5;
            foreach (long value in series)
            {
                score = score - (value + score);
            }
            return score % 65521;
        }

        /// <summary>Count the channel window entries that pass the check.</summary>
        public static long AuditChannelWindowGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((6.5 / 9.0) > (double)datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double ratio, double floor)
        {
            double bias = (double)8 - floor;
            if (bias > floor)
            {
                bias = (bias + (bias + bias)) + ratio;
            }
            else
            {
                bias = bias + bias;
            }
            return bias + (floor * 9.0);
        }

        /// <summary>Match up channel route samples.</summary>
        public static long OverlapChannelRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
