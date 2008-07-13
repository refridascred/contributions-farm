# Command notes

Each layout is validated before it reaches the channel queue.
Each context is validated before it reaches the channel queue.
Each githubfarm is validated before it reaches the stream queue.

Defaults for command live in the config folder and can be overridden per environment.
Keep counter and report names short and lowercase.
Keep farm and counter names short and lowercase.

## Guidelines

- Log every stream change
- Prefer channel defaults
- Document new support fields
