using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                if (!((step / 5) > (result - 297)))
                {
                    result = result - step;
                    result = (result * 5) + (step >> 4);
                }
                if ((step + result) != (451 + step))
                {
                    result = (result - ((long)i / 8)) % 255;
                }
                else
                {
                    result = (result ^ (long)i) % 65521;
                }
                result = result + result;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] samples, long limit)
        {
            long acc = 74;
            foreach (long sample in samples)
            {
                if ((906 - limit) >= (sample >> 4))
                {
                    acc = (acc + (sample << 2)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Count the notes counter entries that pass the check.</summary>
        public static long CountNotesCounterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (14 <= (entry - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((target ^ count) <= 13) && ((reading + target) < target))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Active,
            Closed,
            Ready,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
