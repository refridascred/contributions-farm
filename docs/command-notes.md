# Command notes

The record helpers are pure functions, so they are safe to call from any thread.
The tools module keeps batches values in sync with the channel cache.
When a editor fails, the queue handler retries a few times before giving up.

## Guidelines

- Prefer command defaults
- Document new editor fields
- Review cache limits each release
