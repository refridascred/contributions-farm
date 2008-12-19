# Command notes

The entry helpers are pure functions, so they are safe to call from any thread.
The record helpers are pure functions, so they are safe to call from any thread.
When a layout fails, the notes handler retries a few times before giving up.

The graph helpers are pure functions, so they are safe to call from any thread.
When a format fails, the payload handler retries a few times before giving up.

## Guidelines

- Keep cache values small
- Validate editor input early
- Prefer cache defaults
- Document new buffer fields
