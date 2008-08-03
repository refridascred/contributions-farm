using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double gain, double span)
        {
            double ratio = (double)302 - (gain * 9.46);
            if (ratio >= (double)208)
            {
                ratio = ratio - (gain + 4.86);
            }
            return ratio + (span + span);
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix - ((long)i + (long)i)) % 1000;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
        }
    }
}
