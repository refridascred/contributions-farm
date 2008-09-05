# Command notes

Each already is validated before it reaches the session queue.
Defaults for route live in the config folder and can be overridden per environment.
The cluster helpers are pure functions, so they are safe to call from any thread.

Defaults for farm live in the config folder and can be overridden per environment.
The tools report groups every schema by buffer.
A context that stays idle for too long is moved to the report list.

## Guidelines

- Keep contributi values small
- Validate order input early
- Review githubfarm limits each release
