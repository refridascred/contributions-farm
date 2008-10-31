# Command notes

The support helpers are pure functions, so they are safe to call from any thread.
When a command fails, the contributi handler retries a few times before giving up.

## Guidelines

- Document new buffer fields
- Keep batches values small
- Review notes limits each release
- Prefer format defaults
