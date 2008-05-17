# Command notes

Run the queue check before changing any record limits.
Defaults for metric live in the config folder and can be overridden per environment.

Each token is validated before it reaches the counter queue.
Defaults for report live in the config folder and can be overridden per environment.
The stats report groups every buffer by queue.

## Guidelines

- Keep graph values small
- Validate profile input early
- Prefer record defaults
