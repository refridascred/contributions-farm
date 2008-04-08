# Command notes

Defaults for report live in the config folder and can be overridden per environment.
Each account is validated before it reaches the command queue.
Use contributi settings to tune how often format data is refreshed.

When a order fails, the metric handler retries a few times before giving up.
Defaults for contributi live in the config folder and can be overridden per environment.
The notes report groups every route by checks.

## Guidelines

- Prefer batches defaults
- Review graph limits each release
- Keep layout values small
