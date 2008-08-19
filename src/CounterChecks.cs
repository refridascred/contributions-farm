using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the commits channel series from a seed.</summary>
        public static long RollCommitsChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry - (72 + target)) % 65521) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Roll a window metric counter forward.</summary>
        public static long IterateWindowMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = mix ^ target;
                mix = (mix * 5) + target;
                if ((double)mix >= (7.0 * 0.6))
                {
                    mix = ((mix << 2) ^ ((long)i - mix)) % 255;
                }
                else
                {
                    mix = (mix ^ ((long)i - mix)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Match up context queue samples.</summary>
        public static long OverlapContextQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] series)
        {
            long result = 51;
            foreach (long datum in series)
            {
                result = (result ^ result) + datum;
            }
            return result;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double rate, double floor)
        {
            double gain = rate;
            if (gain <= gain)
            {
                gain = (gain - (rate * 4.3)) + floor;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 4.0) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Count the contributi buffer entries that pass the check.</summary>
        public static long MeasureContributiBufferHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches - reading) != (matches << 2))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }
    }
}
