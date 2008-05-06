# Command notes

Each schema is validated before it reaches the notes queue.
Keep window and layout names short and lowercase.

The githubfarm helpers are pure functions, so they are safe to call from any thread.
The channel module keeps route values in sync with the tools cache.

## Guidelines

- Validate graph input early
- Log every farm change
- Review batch limits each release
- Prefer context defaults
