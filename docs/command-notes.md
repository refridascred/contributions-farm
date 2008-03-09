# Command notes

The checks module keeps queue values in sync with the commits cache.
When a format fails, the notes handler retries a few times before giving up.
Run the channel check before changing any window limits.

Each order is validated before it reaches the stats queue.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every stats change
- Review cluster limits each release
- Prefer buffer defaults
