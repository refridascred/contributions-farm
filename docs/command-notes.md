# Command notes

When a token fails, the counter handler retries a few times before giving up.
Each contributi is validated before it reaches the counter queue.
Run the profile check before changing any buffer limits.

## Guidelines

- Validate token input early
- Review token limits each release
- Keep queue values small
