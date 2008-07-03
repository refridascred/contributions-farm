# Command notes

A farm that stays idle for too long is moved to the cache list.
Run the metric check before changing any notes limits.

The record helpers are pure functions, so they are safe to call from any thread.
Use buffer settings to tune how often metric data is refreshed.
Keep cache and batches names short and lowercase.

## Guidelines

- Document new editor fields
- Keep counter values small
- Review record limits each release
