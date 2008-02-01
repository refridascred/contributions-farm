# Command notes

Defaults for format live in the config folder and can be overridden per environment.
Each token is validated before it reaches the commits queue.

The contributi helpers are pure functions, so they are safe to call from any thread.
Each window is validated before it reaches the graph queue.

## Guidelines

- Keep support values small
- Review githubfarm limits each release
- Document new graph fields
- Validate layout input early
