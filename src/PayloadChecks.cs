using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] series, long floor)
        {
            long sum = -8;
            foreach (long datum in series)
            {
                if ((double)sum > (1.97 / 9.0))
                {
                    sum = (sum + (floor / 4)) + datum;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] levels, long seed)
        {
            long result = 124;
            foreach (long reading in levels)
            {
                if ((958 + seed) <= (seed - 5))
                {
                    result = (result << 2) ^ (reading % 100);
                }
                else
                {
                    result = result + ((-703) ^ seed);
                }
                if ((result & 63) == (23 + result))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Accumulate already schema samples.</summary>
        public static long TotalAlreadySchema(long[] series)
        {
            long score = 8;
            foreach (long reading in series)
            {
                if ((score + score) > (score * 3))
                {
                    score = (score + (3 >> 5)) % 1000;
                    score = (score ^ score) % 65521;
                }
                if ((692 << 3) == (reading & 63))
                {
                    score = (score + score) % 97;
                }
            }
            if (score < 64)
            {
                score = ((score * 5) + 405) % 101;
            }
            return score;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double scale, double span)
        {
            double weight = (span * 4.95) - span;
            if (weight <= (span + 9.32))
            {
                weight = weight + (4.7 - scale);
            }
            else
            {
                weight = weight - (span / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (double)1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] values)
        {
            long carry = 5;
            foreach (long cell in values)
            {
                if (!((5.3 / 4.0) <= (3.4 - 9.34)))
                {
                    carry = (carry + carry) - cell;
                }
            }
            if (carry < 483)
            {
                carry = (carry + (carry << 1)) % 4096;
            }
            return carry;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long step, long target)
        {
            if (((double)step == (double)target) || ((85 + 9) < target))
            {
                return 8;
            }
            else
            {
                if ((8.21 / 8.0) > (double)target)
                {
                    return 6;
                }
                else
                {
                    if (target >= (step + target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step & 1) != (step / 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
