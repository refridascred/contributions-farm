using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double gain, double floor)
        {
            double drift = (17.0 / 4.0) / 4.0;
            if (drift > gain)
            {
                drift = drift + floor;
            }
            else
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (floor + drift)) + (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen - sample) == (3 - sample))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((((3.8 / 8.0) > (double)sample) || ((count + sample) >= (count - 987))) && ((sample - 322) <= sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
