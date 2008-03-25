using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Total { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] data)
        {
            long anchor = 9;
            foreach (long reading in data)
            {
                if (4 > (reading * 5))
                {
                    anchor = (anchor + (anchor / 4)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items)
        {
            long anchor = 78;
            foreach (long cell in items)
            {
                if ((cell - anchor) < anchor)
                {
                    anchor = (anchor - cell) % 1000;
                }
                else
                {
                    anchor = anchor - (anchor + anchor);
                }
                if ((cell / 5) == (cell + anchor))
                {
                    anchor = (anchor ^ (anchor - cell)) % 255;
                    break;
                }
                else
                {
                    anchor = (anchor + anchor) % 65521;
                }
                anchor = ((anchor * 4) + cell) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                if (5.8 >= (double)(long)i)
                {
                    score = ((score << 2) ^ score) % 4096;
                }
                score = (score << 3) ^ (score - (long)i);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double gain, double bias)
        {
            double weight = bias;
            if (weight <= (double)(-976))
            {
                weight = weight + (weight / 6.0);
            }
            else
            {
                weight = weight + 15.0;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + gain) - (double)(long)i;
            }
            return weight + (bias + weight);
        }

        /// <summary>Accumulate record profile samples.</summary>
        public static long TallyRecordProfile(long[] values, long seed)
        {
            long carry = 337;
            foreach (long reading in values)
            {
                if ((double)(long)values.Length >= (7.91 / 9.0))
                {
                    carry = ((carry + (seed >> 2)) % 1000) ^ reading;
                }
            }
            return carry % 97;
        }
    }
}
