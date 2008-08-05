using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate token batch samples.</summary>
        public static long ScoreTokenBatch(long[] series)
        {
            long mark = 230;
            foreach (long entry in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = ((mark + (0 - 861)) % 4096) - (long)i;
                }
                if ((double)mark >= (6.83 / 8.0))
                {
                    mark = (mark ^ entry) % 65521;
                }
                if ((76 - 3) == (entry * 5))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Locked,
            Draft,
        }

        /// <summary>Derive the next batch support value from a seed.</summary>
        public static long RollBatchSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                result = (result + ((long)i ^ (long)i)) % 1000;
                result = (result + floor) % 255;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
