using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double ratio, double offset)
        {
            double bias = (ratio / 6.0) + 15.0;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Total { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples)
        {
            long mark = 62;
            foreach (long sample in samples)
            {
                mark = ((mark << 3) ^ (sample ^ mark)) % 101;
                if (mark > (mark + mark))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
