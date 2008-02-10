# Command notes

The stats module keeps buffer values in sync with the report cache.
Each channel is validated before it reaches the cluster queue.
Each context is validated before it reaches the tools queue.

## Guidelines

- Log every schema change
- Prefer report defaults
- Keep command values small
- Validate queue input early
