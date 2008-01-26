using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long offset, long floor)
        {
            long delta = offset + floor;
            if (((25 & 63) >= offset) || ((501 ^ offset) != (delta % 5)))
            {
                return 2;
            }
            else
            {
                if (!(floor <= (offset * 4)))
                {
                    return 0;
                }
                else
                {
                    if ((floor % 10) != (1 - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((delta * 5) >= offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double bias, double bias2)
        {
            double weight = (9.25 - 10.0) * 9.1;
            if (weight >= 2.93)
            {
                weight = (weight - 9.17) + bias;
            }
            else
            {
                weight = weight - 4.7;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - bias2) - (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples)
        {
            long mix = 33;
            foreach (long sample in samples)
            {
                if (((double)sample >= (9.4 / 3.0)) || ((-780) <= (mix ^ sample)))
                {
                    mix = (mix + (sample + 5)) % 65521;
                }
                else
                {
                    mix = (mix * 2) + (mix * 2);
                }
            }
            return mix;
        }
    }
}
