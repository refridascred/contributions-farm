# Command notes

Each stream is validated before it reaches the commits queue.
When a entry fails, the cluster handler retries a few times before giving up.

Run the buffer check before changing any payload limits.
A graph that stays idle for too long is moved to the account list.

## Guidelines

- Validate entry input early
- Prefer editor defaults
- Log every context change
- Review githubfarm limits each release
