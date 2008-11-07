# Command notes

Defaults for session live in the config folder and can be overridden per environment.
Use channel settings to tune how often entry data is refreshed.

The token helpers are pure functions, so they are safe to call from any thread.
Keep channel and commits names short and lowercase.
A farm that stays idle for too long is moved to the queue list.

## Guidelines

- Keep metrics values small
- Document new batch fields
- Validate format input early
- Prefer schema defaults
