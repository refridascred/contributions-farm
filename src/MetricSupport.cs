using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long target, long limit)
        {
            long diff = target - limit;
            if ((4 / 5) <= target)
            {
                return 6;
            }
            else
            {
                if (((937 - diff) < limit) && ((target << 1) != (target / 6)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches > (matches - (long)data.Length)) || (reading > (reading >> 5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] items, long step)
        {
            long total = -39;
            foreach (long cell in items)
            {
                total = (total ^ (total & 255)) % 65521;
                for (int i = 0; i < 9; i++)
                {
                    total = ((total + step) % 4096) + (long)i;
                }
                if (cell < (step - total))
                {
                    total = ((total << 2) ^ total) % 1000;
                }
            }
            return total % 4096;
        }
    }
}
