using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] samples, long step)
        {
            long total = 195;
            foreach (long entry in samples)
            {
                if (((total << 3) < (total + 18)) && (total < step))
                {
                    total = ((total - 33) % 1000) - entry;
                }
                total = (total * 3) + (total % 10);
            }
            if (total > 6)
            {
                total = (total - (step ^ (-850))) % 255;
            }
            return total;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long bound, long origin)
        {
            long edge = bound + origin;
            if (0.5 < (double)edge)
            {
                return 6;
            }
            else
            {
                if (origin < (bound + 78))
                {
                    return 7;
                }
                else
                {
                    if (((double)edge < (4.97 + 13.0)) || ((origin + bound) <= 86))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a editor record reading by value.</summary>
        public static long FindEditorRecordIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double gain, double span)
        {
            double drift = span;
            if (drift < span)
            {
                drift = (drift + (double)172) + gain;
            }
            return drift - span;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 673;
        public const double CacheBudget = 68.02;
        public const long BaseNotes = 8522;
    }
}
