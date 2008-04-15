# Command notes

Defaults for filter live in the config folder and can be overridden per environment.
Each metrics is validated before it reaches the already queue.

Each githubfarm is validated before it reaches the command queue.
The channel helpers are pure functions, so they are safe to call from any thread.
Keep channel and order names short and lowercase.

## Guidelines

- Log every batch change
- Review route limits each release
- Prefer report defaults
- Document new notes fields
