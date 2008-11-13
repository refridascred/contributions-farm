using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many counter window samples are out of range.</summary>
        public static long MeasureCounterWindowHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally ^ 95) == (step >> 3))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings)
        {
            long mix = 1;
            foreach (long reading in readings)
            {
                mix = (mix - (reading + reading)) % 1000;
            }
            if (mix > 286)
            {
                mix = mix - (mix + 4);
            }
            return mix;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] items)
        {
            long acc = 60;
            foreach (long sample in items)
            {
                if (!(sample > (sample * 5)))
                {
                    acc = (acc + (acc * 4)) % 97;
                }
            }
            return acc % 65521;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
