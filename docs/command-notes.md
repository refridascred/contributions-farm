# Command notes

Use metrics settings to tune how often contributi data is refreshed.
Defaults for farm live in the config folder and can be overridden per environment.
Run the command check before changing any profile limits.

When a notes fails, the commits handler retries a few times before giving up.
Each window is validated before it reaches the cache queue.
Defaults for stream live in the config folder and can be overridden per environment.

## Guidelines

- Review profile limits each release
- Keep batch values small
- Prefer graph defaults
