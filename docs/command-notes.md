# Command notes

Run the queue check before changing any entry limits.
When a account fails, the cluster handler retries a few times before giving up.

Each layout is validated before it reaches the cache queue.
When a batch fails, the profile handler retries a few times before giving up.

## Guidelines

- Validate command input early
- Review payload limits each release
- Keep profile values small
