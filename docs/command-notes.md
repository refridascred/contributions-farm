# Command notes

Run the channel check before changing any support limits.
Defaults for graph live in the config folder and can be overridden per environment.

Defaults for format live in the config folder and can be overridden per environment.
Run the batch check before changing any context limits.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep payload values small
- Validate commits input early
- Prefer record defaults
- Review payload limits each release
