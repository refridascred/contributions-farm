# Command notes

The context helpers are pure functions, so they are safe to call from any thread.
Keep stats and farm names short and lowercase.

When a already fails, the command handler retries a few times before giving up.
Each editor is validated before it reaches the schema queue.

## Guidelines

- Review session limits each release
- Log every layout change
- Validate graph input early
- Document new metrics fields
