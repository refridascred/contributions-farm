# Command notes

A graph that stays idle for too long is moved to the batch list.
Keep farm and route names short and lowercase.

Defaults for report live in the config folder and can be overridden per environment.
The batch helpers are pure functions, so they are safe to call from any thread.
The already helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep filter values small
- Document new payload fields
- Validate order input early
- Review cluster limits each release
