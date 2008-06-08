# Command notes

A stream that stays idle for too long is moved to the command list.
When a stats fails, the payload handler retries a few times before giving up.

Use stats settings to tune how often stats data is refreshed.
Run the githubfarm check before changing any batch limits.

## Guidelines

- Review already limits each release
- Prefer format defaults
- Document new batch fields
