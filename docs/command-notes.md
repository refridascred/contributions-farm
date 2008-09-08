# Command notes

The githubfarm helpers are pure functions, so they are safe to call from any thread.
Each buffer is validated before it reaches the order queue.

## Guidelines

- Document new session fields
- Review window limits each release
- Prefer queue defaults
- Log every counter change
