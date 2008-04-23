# Command notes

Run the tools check before changing any tools limits.
The editor helpers are pure functions, so they are safe to call from any thread.
When a tools fails, the command handler retries a few times before giving up.

## Guidelines

- Review batches limits each release
- Log every order change
- Validate queue input early
