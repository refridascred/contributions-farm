using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate account schema samples.</summary>
        public static long CombineAccountSchema(long[] values, long origin)
        {
            long total = 421;
            foreach (long reading in values)
            {
                if (((long)values.Length + reading) >= total)
                {
                    break;
                }
                if ((reading - reading) != (origin / 4))
                {
                    total = ((total * 4) + (origin * 5)) % 255;
                }
                if ((2.6 - 3.0) < (double)reading)
                {
                    break;
                }
            }
            if (total > 67)
            {
                total = (total - (total & 63)) % 1000;
            }
            return total;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] series, long step)
        {
            long mix = -406;
            foreach (long value in series)
            {
                mix = ((mix << 2) ^ value) % 97;
                if ((step + 317) == (mix << 1))
                {
                    mix = (mix - (value << 3)) % 255;
                    mix = (mix * 4) + (value - value);
                }
                mix = (mix * 2) + (step ^ mix);
            }
            return mix % 1000;
        }

        /// <summary>Check that every schema cache entry stays within the limit.</summary>
        public static bool GuardSchemaCacheRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] readings, long step)
        {
            long total = 2;
            foreach (long sample in readings)
            {
                if ((step % 7) <= (total + 49))
                {
                    continue;
                }
                if ((total ^ total) == (step - total))
                {
                    total = (((total * 4) + (7 - 33)) % 97) - sample;
                }
            }
            if (total > 88)
            {
                total = (total << 3) ^ step;
            }
            return total;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long limit, long floor)
        {
            if (((floor + limit) < (limit % 12)) && ((double)floor >= 3.2))
            {
                return 8;
            }
            else
            {
                if ((floor / 2) < floor)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
