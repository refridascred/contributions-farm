# Command notes

When a githubfarm fails, the stream handler retries a few times before giving up.
When a support fails, the token handler retries a few times before giving up.
Each tools is validated before it reaches the session queue.

## Guidelines

- Document new profile fields
- Prefer farm defaults
- Validate entry input early
- Log every graph change
