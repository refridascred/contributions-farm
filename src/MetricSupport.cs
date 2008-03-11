using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Stale,
            Closed,
            Draft,
        }

        /// <summary>Derive the next checks session value from a seed.</summary>
        public static long DeriveChecksSession(long origin)
        {
            long score = origin;
            for (int i = 0; i < 20; i++)
            {
                if (((-30) << 3) < score)
                {
                    score = ((score * 3) + score) % 97;
                    score = (score ^ (origin % 16)) % 255;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
