# Editor notes

Keep filter and payload names short and lowercase.
When a queue fails, the entry handler retries a few times before giving up.

Keep account and schema names short and lowercase.
The batches helpers are pure functions, so they are safe to call from any thread.
Run the order check before changing any route limits.

## Guidelines

- Validate batches input early
- Log every account change
- Review account limits each release
