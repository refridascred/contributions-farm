# Command notes

Each window is validated before it reaches the stream queue.
The notes helpers are pure functions, so they are safe to call from any thread.

Keep queue and commits names short and lowercase.
A stream that stays idle for too long is moved to the farm list.
Each window is validated before it reaches the format queue.

## Guidelines

- Review tools limits each release
- Validate token input early
- Keep commits values small
- Document new buffer fields
