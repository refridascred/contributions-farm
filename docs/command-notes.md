# Command notes

A command that stays idle for too long is moved to the commits list.
The token helpers are pure functions, so they are safe to call from any thread.
A farm that stays idle for too long is moved to the command list.

A report that stays idle for too long is moved to the support list.
Keep command and context names short and lowercase.
Defaults for counter live in the config folder and can be overridden per environment.

## Guidelines

- Prefer githubfarm defaults
- Validate support input early
- Keep buffer values small
- Document new commits fields
