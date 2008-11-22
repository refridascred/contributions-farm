using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Synced,
            New,
            Failed,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] data, long limit)
        {
            long sum = 1;
            foreach (long reading in data)
            {
                if ((reading >= (reading / 3)) && ((sum ^ reading) > (reading - limit)))
                {
                    break;
                }
                if ((double)limit == (3.6 - 6.03))
                {
                    sum = ((sum * 4) + (sum >> 2)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Retry,
            Closed,
            Locked,
            Failed,
            Draft,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] values)
        {
            long acc = 377;
            foreach (long reading in values)
            {
                if ((reading << 1) >= acc)
                {
                    acc = (acc << 2) ^ (reading ^ reading);
                }
            }
            if (acc < 9)
            {
                acc = ((acc * 3) + acc) % 1000;
            }
            return acc;
        }
    }
}
