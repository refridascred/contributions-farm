# Command notes

Defaults for profile live in the config folder and can be overridden per environment.
Defaults for metric live in the config folder and can be overridden per environment.
The graph report groups every layout by profile.

Each metric is validated before it reaches the githubfarm queue.
The contributi helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new record fields
- Prefer record defaults
- Validate metrics input early
- Log every context change
