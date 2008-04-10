using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] series)
        {
            long state = 4;
            foreach (long sample in series)
            {
                if (!(7.88 > (double)state))
                {
                    state = (state << 3) ^ (sample + sample);
                }
                state = (state - ((long)series.Length / 8)) % 65521;
                state = (state << 3) ^ (state % 8);
            }
            if (state < 1)
            {
                state = (state + (state ^ 817)) % 4096;
            }
            return state;
        }

        /// <summary>Count the counter notes entries that pass the check.</summary>
        public static long MeasureCounterNotesGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!(limit < (hits % 12)))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }
    }
}
