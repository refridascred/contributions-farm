# Command notes

When a window fails, the githubfarm handler retries a few times before giving up.
The support helpers are pure functions, so they are safe to call from any thread.
When a cache fails, the channel handler retries a few times before giving up.

## Guidelines

- Validate channel input early
- Document new buffer fields
- Log every metric change
- Keep layout values small
