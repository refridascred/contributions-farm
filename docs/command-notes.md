# Command notes

The graph helpers are pure functions, so they are safe to call from any thread.
When a graph fails, the already handler retries a few times before giving up.

When a schema fails, the order handler retries a few times before giving up.
Run the command check before changing any command limits.

## Guidelines

- Validate window input early
- Prefer schema defaults
- Log every format change
