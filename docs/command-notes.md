# Command notes

A record that stays idle for too long is moved to the graph list.
Each payload is validated before it reaches the entry queue.

Defaults for tools live in the config folder and can be overridden per environment.
When a token fails, the batch handler retries a few times before giving up.

## Guidelines

- Validate filter input early
- Review githubfarm limits each release
- Keep already values small
- Document new tools fields
