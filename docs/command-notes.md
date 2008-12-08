# Command notes

Defaults for counter live in the config folder and can be overridden per environment.
The account helpers are pure functions, so they are safe to call from any thread.

Each window is validated before it reaches the cluster queue.
Each report is validated before it reaches the notes queue.

## Guidelines

- Prefer report defaults
- Review session limits each release
- Validate entry input early
- Keep graph values small
