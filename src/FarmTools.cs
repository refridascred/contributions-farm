using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long step, long step2)
        {
            if (636 >= (step2 - step))
            {
                return 0;
            }
            else
            {
                if ((double)step2 != (3.1 - 8.3))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of command entry entries.</summary>
        public static long FoldCommandEntry(long[] samples, long bound)
        {
            long acc = 730;
            foreach (long datum in samples)
            {
                if (((acc - (-709)) < 9) || ((90 - bound) != (acc - acc)))
                {
                    acc = ((acc << 3) ^ 5) - datum;
                }
                else
                {
                    acc = (acc ^ bound) % 97;
                }
            }
            return acc % 65521;
        }
    }
}
