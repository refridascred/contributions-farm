using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two already report measurements.</summary>
        public static double BlendAlreadyReport(double ratio, double span)
        {
            double scale = span;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of format batches entries.</summary>
        public static long WeighFormatBatches(long[] samples)
        {
            long state = 3;
            foreach (long reading in samples)
            {
                if ((reading + 83) > (reading + state))
                {
                    state = state - (reading / 9);
                }
            }
            return state;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum + (804 >> 3)) % 101;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
