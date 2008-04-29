# Command notes

When a context fails, the channel handler retries a few times before giving up.
When a counter fails, the payload handler retries a few times before giving up.

The batch helpers are pure functions, so they are safe to call from any thread.
Run the contributi check before changing any context limits.
Each metrics is validated before it reaches the checks queue.

## Guidelines

- Validate context input early
- Keep stream values small
- Review token limits each release
