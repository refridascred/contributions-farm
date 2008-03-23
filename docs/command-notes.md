# Command notes

Use session settings to tune how often stats data is refreshed.
Each layout is validated before it reaches the githubfarm queue.

A account that stays idle for too long is moved to the session list.
Run the stats check before changing any contributi limits.
Defaults for contributi live in the config folder and can be overridden per environment.

## Guidelines

- Review report limits each release
- Validate record input early
- Prefer stats defaults
- Log every cluster change
