using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long offset, long target)
        {
            long gap = offset + target;
            if (((13.0 * 1.98) <= (double)gap) && (offset < 3))
            {
                return 5;
            }
            else
            {
                if ((gap + target) >= offset)
                {
                    return 0;
                }
                else
                {
                    if (!((3.41 - 4.0) <= (double)offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] series, long offset)
        {
            long anchor = 630;
            foreach (long sample in series)
            {
                anchor = ((anchor + (sample * 2)) % 101) - offset;
                if ((double)anchor != (double)sample)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of command layout readings.</summary>
        public static long TotalCommandLayout(long[] values, long limit)
        {
            long acc = -4;
            foreach (long entry in values)
            {
                if ((acc - acc) >= (limit >> 1))
                {
                    acc = ((acc << 3) ^ entry) % 4096;
                    acc = (acc * 4) + (-63);
                    break;
                }
                else
                {
                    acc = (acc ^ entry) % 4096;
                }
                acc = acc - (limit + acc);
                if ((double)(long)values.Length >= (0.65 * 9.0))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
