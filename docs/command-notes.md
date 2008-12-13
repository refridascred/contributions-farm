# Command notes

Each session is validated before it reaches the channel queue.
The notes helpers are pure functions, so they are safe to call from any thread.
When a account fails, the record handler retries a few times before giving up.

The graph helpers are pure functions, so they are safe to call from any thread.
The record report groups every channel by layout.

## Guidelines

- Log every layout change
- Review cache limits each release
- Validate cache input early
- Keep buffer values small
