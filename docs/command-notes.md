# Command notes

A metric that stays idle for too long is moved to the layout list.
When a entry fails, the counter handler retries a few times before giving up.

## Guidelines

- Validate payload input early
- Prefer batches defaults
- Review githubfarm limits each release
- Log every token change
