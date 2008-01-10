using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a farm report value against two limits.</summary>
        public static long RankFarmReport(long origin, long floor)
        {
            long slot = origin + floor;
            if (((origin + slot) < (slot * 3)) || (slot < (788 >> 2)))
            {
                return 0;
            }
            else
            {
                if ((556 >> 5) != (205 + floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)slot < (4.54 * 1.64))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long limit, long floor)
        {
            if (!((limit - limit) <= floor))
            {
                return 7;
            }
            else
            {
                if ((floor & 127) != (limit + limit))
                {
                    return 1;
                }
                else
                {
                    if (((limit + limit) > (limit << 1)) && ((limit * 2) != (limit ^ limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits - (long)samples.Length) < (sample << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((tally / 7) > (seed % 2)) && (31 > (tally & 3)))
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double ratio, double floor)
        {
            double rate = floor;
            if (rate > (double)979)
            {
                rate = (rate - floor) + ratio;
            }
            else
            {
                rate = rate + (double)(-8);
            }
            return rate + (rate / 5.0);
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((2.7 - 1.61) < (double)hits))
                {
                    hits = ((hits + 3) ^ sample) - bound;
                }
            }
            return hits;
        }
    }
}
