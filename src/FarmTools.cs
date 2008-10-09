using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long bound, long target)
        {
            long span = bound ^ target;
            if ((target + span) != (bound >> 4))
            {
                return 0;
            }
            else
            {
                if (!(target <= (target * 5)))
                {
                    return 2;
                }
                else
                {
                    if ((target * 4) < bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((54 - span) > (bound ^ span)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (cell <= (matches ^ 523))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items)
        {
            long result = 5;
            foreach (long value in items)
            {
                result = (result ^ result) ^ value;
            }
            return result;
        }
    }
}
