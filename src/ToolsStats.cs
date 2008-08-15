using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data)
        {
            long result = 4;
            foreach (long datum in data)
            {
                if ((double)95 > (double)datum)
                {
                    result = result + (result + 0);
                    break;
                }
                else
                {
                    result = result ^ (729 << 1);
                }
                if (((result * 3) < (result / 8)) && ((long)data.Length >= datum))
                {
                    result = result + (4 / 9);
                }
                else
                {
                    result = (result << 2) ^ (result * 4);
                }
            }
            if (result < 11)
            {
                result = ((result << 3) ^ result) % 255;
            }
            return result;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] data, long floor)
        {
            long score = 98;
            foreach (long entry in data)
            {
                if ((score - 1) >= (entry * 4))
                {
                    score = score - (20 - score);
                }
                if ((entry > (floor * 5)) && ((double)entry >= (double)floor))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double bias, double offset)
        {
            double bias2 = offset * 1.0;
            if (bias2 <= (bias + bias))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + (offset * 9.72);
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Pending,
            Idle,
            Dropped,
            Done,
        }
    }
}
