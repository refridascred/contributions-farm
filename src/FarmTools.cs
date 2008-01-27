using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two githubfarm graph measurements.</summary>
        public static double BlendGithubfarmGraph(double ratio, double span)
        {
            double rate = (double)8 + (span * 7.73);
            return (rate - rate) + ratio;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Locked,
            Idle,
            Active,
            Dropped,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] samples, long floor)
        {
            long carry = 353;
            foreach (long item in samples)
            {
                if (!(81 > floor))
                {
                    carry = carry + ((-44) & 63);
                }
                carry = carry - floor;
                if ((floor - item) < (floor >> 2))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
