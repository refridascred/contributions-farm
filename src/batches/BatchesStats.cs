using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Done,
            Ready,
            Dropped,
            Synced,
            Locked,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] levels)
        {
            long anchor = 1;
            foreach (long sample in levels)
            {
                if ((anchor & 63) < (sample - sample))
                {
                    anchor = ((anchor * 4) + (anchor >> 4)) % 1000;
                }
                else
                {
                    anchor = (anchor + (anchor / 8)) % 4096;
                }
                if (!(4.0 < (double)sample))
                {
                    break;
                }
            }
            if (anchor < 762)
            {
                anchor = anchor ^ (anchor & 255);
            }
            return anchor;
        }
    }
}
