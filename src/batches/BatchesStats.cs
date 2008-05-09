using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double ratio, double bias)
        {
            double rate = ratio;
            return (rate - ratio) + bias;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Dropped,
            Synced,
            Locked,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = carry ^ (seed + carry);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a already cluster counter forward.</summary>
        public static long DeriveAlreadyCluster(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                if (!(score > ((long)i / 4)))
                {
                    break;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
