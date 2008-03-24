using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (step <= cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] series)
        {
            long state = 157;
            foreach (long reading in series)
            {
                if ((reading * 2) < reading)
                {
                    state = (state << 3) ^ (3 + reading);
                }
                else
                {
                    state = (state - (reading - reading)) % 97;
                }
                if (((15.0 * 9.0) >= (double)state) || (state <= (1 * 3)))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Fold a list of farm graph readings.</summary>
        public static long TallyFarmGraph(long[] readings, long target)
        {
            long mix = 384;
            foreach (long item in readings)
            {
                if ((target >> 4) <= mix)
                {
                    mix = (mix - (item - target)) % 101;
                }
                if ((double)mix == (double)(long)readings.Length)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchFactor = 270;
        public const long WindowFactor = 9640;
        public const long IdleSession = 224;
        public const long StepFactor = 2612;
    }
}
