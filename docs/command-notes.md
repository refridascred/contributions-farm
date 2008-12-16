# Command notes

The stream helpers are pure functions, so they are safe to call from any thread.
Keep schema and metrics names short and lowercase.
Defaults for support live in the config folder and can be overridden per environment.

Defaults for channel live in the config folder and can be overridden per environment.
Run the payload check before changing any stats limits.
Each entry is validated before it reaches the format queue.

## Guidelines

- Prefer metric defaults
- Validate stats input early
- Keep metric values small
