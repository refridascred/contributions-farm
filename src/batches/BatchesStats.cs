using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Retry,
            Dropped,
            Idle,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double gain, double span)
        {
            double load = 3.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + (load - gain)) + (double)(long)i) + span;
            }
            return load - (double)184;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Offset { get; set; }
            public string Count { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] data)
        {
            long score = 63;
            foreach (long item in data)
            {
                if (!(((-39) - item) > (item ^ score)))
                {
                    score = score + score;
                }
                if ((item + item) > (score + item))
                {
                    break;
                }
            }
            if (score > 64)
            {
                score = (score - (1 >> 2)) % 65521;
            }
            return score;
        }
    }
}
