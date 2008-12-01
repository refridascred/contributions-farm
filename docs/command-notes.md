# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
Keep githubfarm and channel names short and lowercase.

Use entry settings to tune how often cluster data is refreshed.
Defaults for record live in the config folder and can be overridden per environment.
Keep payload and route names short and lowercase.

## Guidelines

- Document new layout fields
- Log every stats change
- Validate graph input early
- Prefer queue defaults
