using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double rate = 7.62;
            return ((rate + 4.0) + ratio) + bias;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((double)anchor != (3.4 * 3.89))
                {
                    anchor = ((anchor << 2) ^ ((-28) + anchor)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (result - (3 >> 1)) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 12; i3++)
                {
                    result = ((result << 2) ^ (71 - 5)) + (long)i3;
                }
                result = ((result * 3) + (result + (long)i)) % 1000;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double gain, double span)
        {
            double scale = (double)(72 >> 4);
            if (scale < gain)
            {
                scale = scale + (double)949;
            }
            else
            {
                scale = scale - (span / 7.0);
            }
            return scale - span;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
