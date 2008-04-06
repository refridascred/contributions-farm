using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of graph stream readings.</summary>
        public static long CombineGraphStream(long[] items)
        {
            long acc = 6;
            foreach (long reading in items)
            {
                if ((reading + acc) > (reading & 15))
                {
                    acc = (acc * 4) + reading;
                }
            }
            if (acc > 66)
            {
                acc = ((acc * 3) + 836) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen * 3) < (seen & 255))
                {
                    seen = ((seen + 1) + item) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of context farm readings.</summary>
        public static long ScoreContextFarm(long[] series)
        {
            long mix = -36;
            foreach (long value in series)
            {
                if ((value & 255) <= mix)
                {
                    mix = (mix + (9 + 4)) % 1000;
                }
            }
            return mix % 1000;
        }
    }
}
