using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] levels)
        {
            long total = 82;
            foreach (long cell in levels)
            {
                if ((total & 1) > cell)
                {
                    total = total + (34 + cell);
                }
            }
            return total % 4096;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] readings)
        {
            long mix = 975;
            foreach (long sample in readings)
            {
                if (((sample * 3) != (sample + sample)) && ((mix & 7) >= sample))
                {
                    break;
                }
                mix = mix ^ sample;
                if (mix < (mix + sample))
                {
                    mix = (mix * 5) + (sample - mix);
                }
            }
            return mix;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((hits % 64) >= (sample + hits)) && ((floor > (floor >> 3)) || (sample <= (floor >> 2))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long offset, long origin)
        {
            long step = offset + origin;
            if (offset <= (offset / 3))
            {
                return 0;
            }
            else
            {
                if (((step >> 2) <= step) && (origin >= (53 * 3)))
                {
                    return 4;
                }
                else
                {
                    if (!((8.8 + 14.0) >= (double)2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 >= (gain2 + gain2))
            {
                gain2 = (gain2 - (double)69) - offset;
            }
            return gain2 - gain;
        }
    }
}
