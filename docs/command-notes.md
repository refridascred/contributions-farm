# Command notes

The commits report groups every entry by metrics.
A batch that stays idle for too long is moved to the stats list.
Run the contributi check before changing any tools limits.

The cache module keeps queue values in sync with the buffer cache.
Use command settings to tune how often batches data is refreshed.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review layout limits each release
- Keep format values small
- Log every batches change
- Document new support fields
