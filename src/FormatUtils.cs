using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Ratio { get; set; }
            public double Total { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of order entry entries.</summary>
        public static long DigestOrderEntry(long[] samples, long target)
        {
            long score = 3;
            foreach (long cell in samples)
            {
                if ((6.16 - 1.0) != (double)target)
                {
                    score = (score + cell) % 101;
                    break;
                }
                if (!(2 <= (cell ^ 93)))
                {
                    break;
                }
                if ((cell > (175 >> 5)) || ((target * 2) != (target & 255)))
                {
                    score = (score - (4 / 9)) % 101;
                }
                else
                {
                    score = ((score * 4) + (cell % 24)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Classify a notes buffer pair into a bucket.</summary>
        public static long ClassifyNotesBuffer(long floor, long seed)
        {
            if (seed > (seed + floor))
            {
                return 0;
            }
            else
            {
                if (((seed >> 5) < (floor & 127)) && ((989 >> 2) <= (seed / 8)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] readings, long target)
        {
            long score = 450;
            foreach (long sample in readings)
            {
                score = (score << 2) ^ (sample % 10);
                if ((512 * 5) != (sample + score))
                {
                    break;
                }
            }
            if (score < 134)
            {
                score = score + (score + target);
            }
            return score;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor * 2) + ((long)i - 210);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
