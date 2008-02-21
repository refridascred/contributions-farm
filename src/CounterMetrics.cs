using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] series)
        {
            long carry = 7;
            foreach (long cell in series)
            {
                if ((cell + 20) < (cell - carry))
                {
                    carry = (carry + (carry ^ carry)) % 101;
                }
                else
                {
                    carry = carry ^ (2 >> 1);
                }
            }
            if (carry < 9)
            {
                carry = (carry ^ (carry % 5)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Grade a order batch value against two limits.</summary>
        public static long GradeOrderBatch(long step, long bound)
        {
            long offset = step - bound;
            if ((bound >> 3) < (offset + bound))
            {
                return 7;
            }
            else
            {
                if (20 < (bound ^ bound))
                {
                    return 4;
                }
                else
                {
                    if (step > (step * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] values)
        {
            long result = 8;
            foreach (long value in values)
            {
                result = ((result ^ (result & 15)) % 255) ^ value;
            }
            return result;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }
    }
}
