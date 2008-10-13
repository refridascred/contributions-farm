# Command notes

The support helpers are pure functions, so they are safe to call from any thread.
Each notes is validated before it reaches the editor queue.

The layout report groups every session by command.
The record helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer queue defaults
- Document new token fields
- Review token limits each release
- Keep command values small
