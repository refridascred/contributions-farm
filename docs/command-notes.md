# Command notes

Each checks is validated before it reaches the context queue.
A schema that stays idle for too long is moved to the channel list.
Each already is validated before it reaches the format queue.

## Guidelines

- Log every cache change
- Keep batch values small
- Prefer channel defaults
- Validate session input early
