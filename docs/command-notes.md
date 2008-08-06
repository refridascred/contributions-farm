# Command notes

Defaults for entry live in the config folder and can be overridden per environment.
Each batches is validated before it reaches the graph queue.

Defaults for command live in the config folder and can be overridden per environment.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every buffer change
- Validate record input early
- Prefer githubfarm defaults
- Document new cluster fields
