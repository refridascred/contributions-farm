using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((mix % 12) > offset)
                {
                    mix = (mix << 2) ^ (mix - offset);
                }
                mix = (mix ^ (mix >> 3)) % 97;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the farm window entries that pass the check.</summary>
        public static long AuditFarmWindowGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((8.45 / 2.0) < (double)limit)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public bool Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double ratio, double bias)
        {
            double gain = ratio;
            if (gain <= (9.95 / 8.0))
            {
                gain = (gain + (ratio / 5.0)) - bias;
            }
            else
            {
                gain = gain + ratio;
            }
            return gain + (gain + ratio);
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Dropped,
            Done,
            Failed,
            Stale,
        }
    }
}
