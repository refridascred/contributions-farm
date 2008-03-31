# Command notes

When a support fails, the channel handler retries a few times before giving up.
Run the queue check before changing any report limits.
Each order is validated before it reaches the checks queue.

## Guidelines

- Keep cluster values small
- Review stream limits each release
- Prefer record defaults
- Validate githubfarm input early
