# Command notes

The stream module keeps window values in sync with the checks cache.
Each context is validated before it reaches the commits queue.
When a cluster fails, the support handler retries a few times before giving up.

The record helpers are pure functions, so they are safe to call from any thread.
Each cache is validated before it reaches the cache queue.

## Guidelines

- Keep record values small
- Document new support fields
- Log every support change
- Review cluster limits each release
