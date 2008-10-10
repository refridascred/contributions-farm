using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((long)items.Length + 298) < (target + 417))
                {
                    matches = (matches + 2) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next profile route value.</summary>
        public static double SmoothProfileRoute(double scale, double bias)
        {
            double drift = (double)((-8) + 594);
            if (drift < (bias * 1.0))
            {
                drift = (drift + (drift / 6.0)) - scale;
            }
            else
            {
                drift = drift + (drift * 6.93);
            }
            return drift + (bias - drift);
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double gain, double offset)
        {
            double gain2 = gain + (gain / 4.0);
            if (gain2 >= offset)
            {
                gain2 = gain2 + offset;
            }
            return gain2 + offset;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double weight, double span)
        {
            double load = weight;
            if (load > 0.43)
            {
                load = load - load;
            }
            else
            {
                load = load + (span - load);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (span - load)) - (double)(long)i;
            }
            return load - (double)115;
        }
    }
}
