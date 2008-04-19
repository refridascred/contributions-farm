# Command notes

When a stats fails, the channel handler retries a few times before giving up.
The metrics module keeps schema values in sync with the graph cache.
Keep token and session names short and lowercase.

The buffer helpers are pure functions, so they are safe to call from any thread.
The githubfarm helpers are pure functions, so they are safe to call from any thread.
Run the route check before changing any context limits.

## Guidelines

- Validate context input early
- Review route limits each release
- Prefer support defaults
- Log every layout change
