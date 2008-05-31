# Command notes

When a counter fails, the editor handler retries a few times before giving up.
Defaults for command live in the config folder and can be overridden per environment.
Run the tools check before changing any token limits.

Run the batches check before changing any queue limits.
Use context settings to tune how often stream data is refreshed.

## Guidelines

- Keep session values small
- Validate already input early
- Prefer batches defaults
