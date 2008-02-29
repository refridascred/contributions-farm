# Command notes

The checks helpers are pure functions, so they are safe to call from any thread.
Each command is validated before it reaches the command queue.
A entry that stays idle for too long is moved to the report list.

## Guidelines

- Review format limits each release
- Log every filter change
- Document new order fields
- Prefer schema defaults
