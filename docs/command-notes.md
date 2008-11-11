# Command notes

Each githubfarm is validated before it reaches the order queue.
When a token fails, the contributi handler retries a few times before giving up.

## Guidelines

- Prefer window defaults
- Validate payload input early
- Document new token fields
