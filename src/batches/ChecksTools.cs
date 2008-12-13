using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the support account series from a seed.</summary>
        public static long DeriveSupportAccount(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i % 60) < (34 / 2))
                {
                    result = ((result * 5) + (target + result)) % 4096;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of layout route readings.</summary>
        public static long TotalLayoutRoute(long[] items, long bound)
        {
            long score = 40;
            foreach (long reading in items)
            {
                score = (score + (reading % 97)) % 101;
                score = score ^ (bound + bound);
                if ((reading >= (0 >> 3)) || ((reading - (-50)) != (bound + score)))
                {
                    break;
                }
            }
            if (score > 13)
            {
                score = (score + ((long)items.Length & 63)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Failed,
            Ready,
            Draft,
            Done,
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
