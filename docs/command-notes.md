# Command notes

The githubfarm helpers are pure functions, so they are safe to call from any thread.
The order report groups every channel by payload.
The format module keeps metrics values in sync with the payload cache.

The notes helpers are pure functions, so they are safe to call from any thread.
Keep metric and buffer names short and lowercase.
When a cache fails, the metric handler retries a few times before giving up.

## Guidelines

- Review contributi limits each release
- Validate githubfarm input early
- Log every tools change
