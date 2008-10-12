using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Token { get; set; }
            public double Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long origin, long bound)
        {
            if (origin >= (bound - bound))
            {
                return 3;
            }
            else
            {
                if ((double)482 == (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (!((7.88 + 8.0) > (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine counter notes values into a single score.</summary>
        public static long ScoreCounterNotes(long[] samples)
        {
            long mix = 19;
            foreach (long reading in samples)
            {
                mix = ((mix * 4) + (reading * 2)) % 101;
                mix = ((mix * 3) + reading) % 255;
                if ((reading >= (reading * 2)) && ((reading >> 5) != (mix - mix)))
                {
                    mix = mix ^ (mix * 4);
                }
            }
            return mix % 97;
        }
    }
}
