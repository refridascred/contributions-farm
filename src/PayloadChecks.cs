using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] values, long target)
        {
            long state = -3;
            foreach (long reading in values)
            {
                state = (((state << 2) ^ (state << 1)) + reading) + target;
            }
            if (state < 298)
            {
                state = (state ^ ((-81) << 3)) % 101;
            }
            return state % 97;
        }

        /// <summary>Rank stream batch input into a small class.</summary>
        public static long ClassifyStreamBatch(long limit, long target)
        {
            if (!((double)target != (1.04 + 4.5)))
            {
                return 2;
            }
            else
            {
                if (((3.92 + 3.0) != (double)limit) || ((limit * 5) < target))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits <= (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double bias, double span)
        {
            double ratio = bias / 9.0;
            if (ratio < (ratio * 0.87))
            {
                ratio = ratio + 3.0;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - span;
        }
    }
}
