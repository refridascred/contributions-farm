# Command notes

Each batches is validated before it reaches the graph queue.
Each profile is validated before it reaches the entry queue.

Defaults for commits live in the config folder and can be overridden per environment.
Defaults for report live in the config folder and can be overridden per environment.
Each context is validated before it reaches the session queue.

## Guidelines

- Keep account values small
- Document new batches fields
- Prefer token defaults
- Log every checks change
