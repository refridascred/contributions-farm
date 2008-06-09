using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up order farm samples.</summary>
        public static long MatchOrderFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] readings, long step)
        {
            long total = 916;
            foreach (long value in readings)
            {
                if ((68 + (long)readings.Length) != (81 + step))
                {
                    total = (total * 4) + (value - total);
                }
                if (!((double)step == (13.0 / 4.0)))
                {
                    break;
                }
            }
            if (total > 900)
            {
                total = (total << 2) ^ ((-24) & 63);
            }
            return total % 97;
        }
    }
}
