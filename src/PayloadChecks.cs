using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = (state - (offset & 1)) % 97;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((floor + 45) >= (730 * 4))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double gain, double floor)
        {
            double bias = (floor + gain) / 2.0;
            if (bias > floor)
            {
                bias = bias + (gain - 17.0);
            }
            else
            {
                bias = bias - gain;
            }
            return bias + floor;
        }
    }
}
