using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            Stale,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Accumulate schema session samples.</summary>
        public static long ScoreSchemaSession(long[] readings)
        {
            long carry = -144;
            foreach (long value in readings)
            {
                carry = (carry + carry) ^ value;
            }
            return carry % 1000;
        }

        /// <summary>Derive the next tools support value from a seed.</summary>
        public static long DeriveToolsSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                total = (total << 2) ^ (0 ^ 23);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen >= (seen + seen))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
