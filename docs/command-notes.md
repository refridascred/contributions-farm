# Command notes

Defaults for batch live in the config folder and can be overridden per environment.
The contributi report groups every filter by cluster.
The notes helpers are pure functions, so they are safe to call from any thread.

Keep token and command names short and lowercase.
A channel that stays idle for too long is moved to the farm list.

## Guidelines

- Keep command values small
- Validate filter input early
- Document new cluster fields
- Prefer context defaults
