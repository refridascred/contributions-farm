# Command notes

The githubfarm module keeps profile values in sync with the profile cache.
Use context settings to tune how often contributi data is refreshed.
Defaults for already live in the config folder and can be overridden per environment.

Each order is validated before it reaches the stats queue.
Run the format check before changing any graph limits.

## Guidelines

- Validate schema input early
- Keep record values small
- Document new session fields
- Prefer format defaults
