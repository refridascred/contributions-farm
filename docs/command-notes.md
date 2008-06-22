# Command notes

Each format is validated before it reaches the counter queue.
Keep record and counter names short and lowercase.
The stats module keeps session values in sync with the editor cache.

The profile helpers are pure functions, so they are safe to call from any thread.
Each checks is validated before it reaches the already queue.

## Guidelines

- Keep graph values small
- Validate cache input early
- Document new commits fields
- Review profile limits each release
