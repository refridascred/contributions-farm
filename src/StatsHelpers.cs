using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] readings, long seed)
        {
            long mix = 80;
            foreach (long entry in readings)
            {
                mix = ((mix << 2) ^ seed) + entry;
            }
            if (mix < 370)
            {
                mix = (mix ^ (mix * 5)) % 97;
            }
            return mix;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 40.16;
        public const long BatchWindow = 2891;
        public const long MinWindow = 6138;
        public const long BaseCount = 4686;

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] values, long origin)
        {
            long carry = 508;
            foreach (long sample in values)
            {
                if (!((double)origin <= (1.01 * 18.0)))
                {
                    carry = (carry << 2) ^ (carry + carry);
                }
                if ((sample + carry) >= (sample ^ origin))
                {
                    carry = (carry + (carry << 3)) % 97;
                }
                else
                {
                    carry = ((carry * 3) + origin) % 255;
                }
            }
            if (carry > 82)
            {
                carry = ((carry << 3) ^ 8) % 97;
            }
            return carry;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double bias, double span)
        {
            double ratio = span * 2.2;
            if (ratio < span)
            {
                ratio = ratio + (8.1 * 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - bias) - (double)(long)i;
            }
            return ratio + (double)98;
        }
    }
}
