# Command notes

A cache that stays idle for too long is moved to the cache list.
A window that stays idle for too long is moved to the githubfarm list.
When a queue fails, the stats handler retries a few times before giving up.

## Guidelines

- Review stream limits each release
- Document new cluster fields
- Validate stats input early
