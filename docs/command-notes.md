# Command notes

A graph that stays idle for too long is moved to the schema list.
Each commits is validated before it reaches the batch queue.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate stats input early
- Prefer already defaults
- Keep payload values small
- Review already limits each release
