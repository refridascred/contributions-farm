# Command notes

Use notes settings to tune how often entry data is refreshed.
Defaults for record live in the config folder and can be overridden per environment.
Run the format check before changing any already limits.

The batch report groups every buffer by record.
Keep queue and cache names short and lowercase.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer session defaults
- Validate record input early
- Keep command values small
