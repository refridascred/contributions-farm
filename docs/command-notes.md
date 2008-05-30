# Command notes

Each command is validated before it reaches the context queue.
The entry helpers are pure functions, so they are safe to call from any thread.
The graph module keeps channel values in sync with the buffer cache.

Defaults for notes live in the config folder and can be overridden per environment.
The session module keeps entry values in sync with the stream cache.

## Guidelines

- Review channel limits each release
- Keep session values small
- Validate commits input early
