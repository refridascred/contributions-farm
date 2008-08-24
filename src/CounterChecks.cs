using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Paused,
            Done,
            Idle,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] samples)
        {
            long carry = 80;
            foreach (long cell in samples)
            {
                if (((-4) < (cell + cell)) && ((carry * 3) > cell))
                {
                    carry = (carry ^ carry) % 101;
                }
            }
            if (carry < (-799))
            {
                carry = (carry << 2) ^ carry;
            }
            return carry % 4096;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Idle,
            Draft,
            New,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] readings, long bound)
        {
            long anchor = 25;
            foreach (long item in readings)
            {
                anchor = (((anchor << 2) ^ (bound & 63)) % 65521) ^ item;
            }
            if (anchor < 5)
            {
                anchor = ((anchor << 2) ^ anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many profile cache samples are out of range.</summary>
        public static long TallyProfileCacheMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((276 % 2) >= (value ^ 750))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                if ((step + step) > (step + anchor))
                {
                    anchor = (anchor << 2) ^ step;
                    anchor = anchor - (step % 97);
                }
                anchor = anchor + step;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
