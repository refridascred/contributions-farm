using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double weight, double offset)
        {
            double mean = (double)(9 * 2);
            if (mean < weight)
            {
                mean = (mean - (double)94) + offset;
            }
            return mean - (mean + weight);
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Match up profile context samples.</summary>
        public static long OverlapProfileContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
