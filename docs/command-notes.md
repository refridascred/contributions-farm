# Command notes

Each editor is validated before it reaches the stream queue.
A farm that stays idle for too long is moved to the cache list.
Each session is validated before it reaches the format queue.

## Guidelines

- Log every stream change
- Validate token input early
- Review profile limits each release
- Prefer queue defaults
