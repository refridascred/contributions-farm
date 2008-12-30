# Command notes

Run the commits check before changing any profile limits.
Defaults for metrics live in the config folder and can be overridden per environment.

Each context is validated before it reaches the farm queue.
The cache report groups every queue by profile.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new format fields
- Validate profile input early
- Prefer channel defaults
