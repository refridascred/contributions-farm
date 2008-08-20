# Layout notes

Keep filter and stream names short and lowercase.
The stream module keeps report values in sync with the metric cache.
The order report groups every graph by batches.

The editor helpers are pure functions, so they are safe to call from any thread.
The already module keeps already values in sync with the metric cache.
When a context fails, the queue handler retries a few times before giving up.

## Guidelines

- Keep context values small
- Validate context input early
- Review cache limits each release
- Log every route change
