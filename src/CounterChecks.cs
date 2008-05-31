using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item <= (2 % 8))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] data)
        {
            long mix = 31;
            foreach (long value in data)
            {
                if (((5.0 + 8.5) != (double)mix) && ((mix - 9) <= (754 & 127)))
                {
                    mix = (mix ^ (value * 3)) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] values)
        {
            long anchor = -33;
            foreach (long datum in values)
            {
                if (((datum - anchor) == (926 + anchor)) && ((anchor << 2) < anchor))
                {
                    anchor = ((anchor * 5) + (datum & 127)) % 65521;
                }
            }
            if (anchor < 54)
            {
                anchor = (anchor * 3) + anchor;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] series)
        {
            long carry = -422;
            foreach (long sample in series)
            {
                if (!(carry >= (carry ^ carry)))
                {
                    carry = ((carry << 3) ^ (carry - sample)) % 4096;
                }
                if ((sample + 4) > (48 - carry))
                {
                    carry = ((carry << 3) ^ sample) % 4096;
                }
            }
            if (carry > 420)
            {
                carry = carry ^ (carry << 3);
            }
            return carry % 4096;
        }

        /// <summary>Check that every command farm entry stays within the limit.</summary>
        public static bool GuardCommandFarmBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
