# Command notes

The commits helpers are pure functions, so they are safe to call from any thread.
Each already is validated before it reaches the schema queue.
Run the stats check before changing any command limits.

## Guidelines

- Keep route values small
- Prefer context defaults
- Review route limits each release
