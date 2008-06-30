# Command notes

Run the report check before changing any commits limits.
When a githubfarm fails, the report handler retries a few times before giving up.
Each checks is validated before it reaches the order queue.

## Guidelines

- Keep route values small
- Validate batches input early
- Document new window fields
- Review entry limits each release
