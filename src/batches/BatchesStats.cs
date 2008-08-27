using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Queued,
            Paused,
            Done,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] data)
        {
            long carry = 4;
            foreach (long item in data)
            {
                if ((carry - item) > (carry % 5))
                {
                    carry = (carry ^ (carry + item)) % 101;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry * 3)) % 101;
                }
            }
            if (carry > 3)
            {
                carry = carry - (carry * 5);
            }
            return carry % 97;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long anchor = 0;
            foreach (long item in readings)
            {
                if (!((double)item <= 15.0))
                {
                    anchor = (anchor << 3) ^ (item << 1);
                }
                else
                {
                    anchor = (anchor - anchor) % 97;
                }
            }
            return anchor;
        }
    }
}
