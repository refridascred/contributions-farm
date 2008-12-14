using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate githubfarm batches samples.</summary>
        public static long ScoreGithubfarmBatches(long[] data)
        {
            long mark = 317;
            foreach (long value in data)
            {
                if ((mark + value) >= (mark >> 3))
                {
                    mark = (mark + value) % 255;
                }
            }
            if (mark > 3)
            {
                mark = (mark + (mark + mark)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((value >> 5) < value) || (value < seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public double Score { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
