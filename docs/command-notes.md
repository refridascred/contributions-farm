# Command notes

A record that stays idle for too long is moved to the editor list.
Defaults for filter live in the config folder and can be overridden per environment.

Each stats is validated before it reaches the notes queue.
The command helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review counter limits each release
- Document new filter fields
- Prefer command defaults
