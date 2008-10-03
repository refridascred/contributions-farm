# Command notes

When a session fails, the metrics handler retries a few times before giving up.
The support report groups every context by token.

Keep window and metrics names short and lowercase.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate farm input early
- Log every metrics change
- Prefer context defaults
- Review support limits each release
