using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every graph account entry stays within the limit.</summary>
        public static bool ValidateGraphAccountBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long offset, long seed)
        {
            long prev = offset ^ seed;
            if ((2.62 * 6.5) > (double)offset)
            {
                return 0;
            }
            else
            {
                if ((double)prev < (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((9.0 + 11.0) <= (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed - prev) == (offset + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Level { get; set; }
            public double Label { get; set; }
            public long Count { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
