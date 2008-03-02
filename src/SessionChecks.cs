using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((seen + seen) >= datum) || !((datum + seen) < (seen - 0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double weight, double offset)
        {
            double drift = weight / 4.0;
            if (drift <= offset)
            {
                drift = drift - (offset - offset);
            }
            else
            {
                drift = drift - (drift + 4.9);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift * 6.0)) + (double)(long)i;
            }
            return drift + (6.0 - 9.0);
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Locked,
            Pending,
            Failed,
        }
    }
}
