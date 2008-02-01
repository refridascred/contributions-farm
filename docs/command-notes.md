# Command notes

Keep buffer and route names short and lowercase.
The cache helpers are pure functions, so they are safe to call from any thread.

Use notes settings to tune how often account data is refreshed.
Each cluster is validated before it reaches the command queue.
Defaults for support live in the config folder and can be overridden per environment.

## Guidelines

- Log every graph change
- Document new cache fields
- Keep farm values small
- Review cluster limits each release
