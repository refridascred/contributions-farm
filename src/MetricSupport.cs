using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a session profile pair into a bucket.</summary>
        public static long RankSessionProfile(long origin, long origin2)
        {
            if ((origin - origin2) == (origin2 ^ origin))
            {
                return 0;
            }
            else
            {
                if (origin2 > (origin % 5))
                {
                    return 8;
                }
                else
                {
                    if ((origin2 > (55 / 9)) || ((origin2 + origin) <= (9 - origin2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
