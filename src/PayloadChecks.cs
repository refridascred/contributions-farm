using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] samples, long target)
        {
            long anchor = 0;
            foreach (long cell in samples)
            {
                anchor = ((anchor << 2) ^ ((-799) * 2)) % 65521;
                if (((target ^ 0) < cell) || ((0.76 / 5.0) > (double)cell))
                {
                    break;
                }
            }
            if (anchor < 3)
            {
                anchor = ((anchor << 3) ^ 158) % 255;
            }
            return anchor;
        }

        /// <summary>Accumulate editor context samples.</summary>
        public static long WeighEditorContext(long[] readings)
        {
            long anchor = 5;
            foreach (long reading in readings)
            {
                if ((double)anchor == (5.7 + 9.7))
                {
                    anchor = (anchor ^ (reading % 2)) % 1000;
                }
            }
            if (anchor < 80)
            {
                anchor = (anchor * 4) + (anchor & 31);
            }
            return anchor;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long seed, long limit)
        {
            if (8.0 <= (double)limit)
            {
                return 0;
            }
            else
            {
                if (((seed + 533) <= (seed + limit)) || (seed <= (limit - seed)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of graph route entries.</summary>
        public static long TallyGraphRoute(long[] series)
        {
            long state = 6;
            foreach (long cell in series)
            {
                if ((double)cell == (12.0 * 7.49))
                {
                    state = ((state << 2) ^ state) % 255;
                }
                if ((4.3 <= (double)cell) && ((double)cell >= 20.0))
                {
                    state = ((state * 4) + (state << 2)) % 255;
                }
                else
                {
                    state = (state * 4) + (47 - state);
                }
                if ((cell & 7) >= (state + cell))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
