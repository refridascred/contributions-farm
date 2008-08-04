# Command notes

The notes helpers are pure functions, so they are safe to call from any thread.
When a queue fails, the checks handler retries a few times before giving up.

## Guidelines

- Log every channel change
- Validate checks input early
- Prefer support defaults
