# Command notes

The queue report groups every payload by entry.
Keep command and checks names short and lowercase.
Use checks settings to tune how often cache data is refreshed.

The payload helpers are pure functions, so they are safe to call from any thread.
Each metrics is validated before it reaches the report queue.

## Guidelines

- Keep graph values small
- Log every channel change
- Validate context input early
