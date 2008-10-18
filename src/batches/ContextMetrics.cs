using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double weight, double offset)
        {
            double drift = weight + weight;
            if (drift < drift)
            {
                drift = drift + (double)171;
            }
            else
            {
                drift = drift - (offset * 13.0);
            }
            return drift + (double)35;
        }

        /// <summary>Look up the position of a notes session sample.</summary>
        public static long LookupNotesSessionIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long floor)
        {
            long state = floor;
            for (int i = 0; i < 17; i++)
            {
                if (!((5.04 / 5.0) != (double)state))
                {
                    state = state ^ (floor + (long)i);
                }
                else
                {
                    state = (state ^ (floor + (long)i)) % 255;
                }
                state = state + ((long)i * 2);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
