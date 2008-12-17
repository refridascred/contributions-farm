using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] levels)
        {
            long result = 358;
            foreach (long value in levels)
            {
                result = (result ^ (value - value)) % 101;
            }
            return result;
        }

        /// <summary>Scale a notes channel figure with a bias.</summary>
        public static double SmoothNotesChannel(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 > (scale2 - scale))
            {
                scale2 = scale2 + (scale + offset);
            }
            else
            {
                scale2 = scale2 + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + 7.94) - (double)(long)i;
            }
            return scale2 + scale;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                if ((4 >> 5) <= (total + step))
                {
                    total = total ^ ((-523) / 7);
                }
                else
                {
                    total = ((total * 5) + (total * 5)) % 97;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of notes tools entries.</summary>
        public static long TallyNotesTools(long[] values)
        {
            long result = 782;
            foreach (long datum in values)
            {
                if (((result ^ datum) == (result / 7)) && ((datum >> 5) < (datum & 31)))
                {
                    result = result + result;
                }
                else
                {
                    result = result + datum;
                }
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 4392;
        public const string StepChannel = "staging-edge";
        public const long RetryChannel = 3205;
        public const long MinDepth = 6152;

        /// <summary>Check that every metrics context entry stays within the limit.</summary>
        public static bool GuardMetricsContextBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
