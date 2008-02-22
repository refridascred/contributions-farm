using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long origin, long bound)
        {
            if (!((bound << 3) >= origin))
            {
                return 4;
            }
            else
            {
                if (bound <= ((-639) % 60))
                {
                    return 1;
                }
                else
                {
                    if (!((origin & 15) == (9 + origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((13.0 + 6.59) <= (double)origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell - 964) > tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
