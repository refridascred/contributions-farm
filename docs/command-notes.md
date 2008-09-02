# Command notes

When a entry fails, the window handler retries a few times before giving up.
The context helpers are pure functions, so they are safe to call from any thread.
When a report fails, the batch handler retries a few times before giving up.

## Guidelines

- Validate graph input early
- Prefer schema defaults
- Log every format change
