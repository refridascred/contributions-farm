# Command notes

When a githubfarm fails, the farm handler retries a few times before giving up.
Each farm is validated before it reaches the context queue.

## Guidelines

- Validate metrics input early
- Review tools limits each release
- Log every metric change
