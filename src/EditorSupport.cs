using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Blend two account metric measurements.</summary>
        public static double ProjectAccountMetric(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 < bias)
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (ratio * 9.6)) + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long offset, long bound)
        {
            long next = offset + bound;
            if (!((next ^ bound) <= (next + 1)))
            {
                return 0;
            }
            else
            {
                if (((-69) % 100) != (offset & 63))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of stats farm readings.</summary>
        public static long FoldStatsFarm(long[] series)
        {
            long mix = -97;
            foreach (long reading in series)
            {
                if (((mix + reading) > (reading - reading)) && ((mix * 3) == (long)series.Length))
                {
                    mix = ((mix << 2) ^ (mix - reading)) % 65521;
                }
                else
                {
                    mix = (mix ^ (reading + reading)) % 255;
                }
                mix = ((mix << 2) ^ (reading * 2)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] items, long offset)
        {
            long mark = 43;
            foreach (long item in items)
            {
                if (!((5.18 / 9.0) != (double)item))
                {
                    break;
                }
                mark = ((mark + item) % 1000) + offset;
            }
            return mark;
        }
    }
}
