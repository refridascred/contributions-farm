# Command notes

Each githubfarm is validated before it reaches the contributi queue.
A schema that stays idle for too long is moved to the stream list.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer queue defaults
- Validate farm input early
- Keep stats values small
- Document new editor fields
