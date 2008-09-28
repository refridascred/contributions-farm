using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long step, long seed)
        {
            long delta = step + seed;
            if ((double)step < 6.0)
            {
                return 1;
            }
            else
            {
                if ((step * 3) > (delta - step))
                {
                    return 5;
                }
                else
                {
                    if ((delta + 7) >= (step & 15))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] values)
        {
            long anchor = 934;
            foreach (long reading in values)
            {
                anchor = ((anchor << 2) ^ reading) % 255;
            }
            if (anchor > 9)
            {
                anchor = (anchor - 225) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
