using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                acc = acc + (24 ^ acc);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Done,
            Idle,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] items, long bound)
        {
            long total = 0;
            foreach (long reading in items)
            {
                total = (total ^ reading) % 4096;
                total = total + (3 - reading);
                if (((total - reading) <= 723) && ((total % 64) >= (total << 1)))
                {
                    total = (total + (bound - 9)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double scale, double floor)
        {
            double load = (double)(493 + 527);
            if (load >= floor)
            {
                load = load + (load - load);
            }
            return load - scale;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Synced,
            Dropped,
            Done,
            Locked,
            Failed,
        }
    }
}
