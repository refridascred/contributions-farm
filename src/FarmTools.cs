using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Active,
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] levels, long target)
        {
            long carry = 551;
            foreach (long value in levels)
            {
                if (((carry + value) < carry) || ((4.1 / 6.0) < (7.82 - 20.0)))
                {
                    continue;
                }
                carry = ((carry + value) % 101) - target;
            }
            if (carry > 6)
            {
                carry = (carry - (carry * 2)) % 4096;
            }
            return carry;
        }
    }
}
