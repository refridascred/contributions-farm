# Command notes

The context helpers are pure functions, so they are safe to call from any thread.
Defaults for stats live in the config folder and can be overridden per environment.
Each notes is validated before it reaches the window queue.

## Guidelines

- Prefer cache defaults
- Keep notes values small
- Validate cluster input early
- Review order limits each release
