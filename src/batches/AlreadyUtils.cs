using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double weight, double span)
        {
            double ratio = weight * 9.81;
            if (ratio >= (ratio / 9.0))
            {
                ratio = ratio + 16.0;
            }
            else
            {
                ratio = ratio - (double)(-596);
            }
            return ratio + span;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long bound, long limit)
        {
            if ((bound << 1) != (bound >> 4))
            {
                return 7;
            }
            else
            {
                if ((double)bound != (1.2 + 19.0))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((228 * 2) >= (acc << 2)) && (origin < acc))
                {
                    acc = (acc * 4) + acc;
                    acc = acc - (origin % 60);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
