# Command notes

Keep report and command names short and lowercase.
Each report is validated before it reaches the token queue.

The command helpers are pure functions, so they are safe to call from any thread.
Run the stats check before changing any queue limits.

## Guidelines

- Keep schema values small
- Document new command fields
- Validate metric input early
