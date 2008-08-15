# Command notes

Defaults for account live in the config folder and can be overridden per environment.
Run the entry check before changing any route limits.
Run the profile check before changing any window limits.

Each entry is validated before it reaches the stats queue.
Keep account and stats names short and lowercase.

## Guidelines

- Keep channel values small
- Prefer counter defaults
- Validate stats input early
- Document new already fields
