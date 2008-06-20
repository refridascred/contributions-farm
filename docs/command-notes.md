# Command notes

The tools report groups every route by queue.
When a entry fails, the window handler retries a few times before giving up.
Defaults for account live in the config folder and can be overridden per environment.

A metric that stays idle for too long is moved to the batches list.
When a schema fails, the channel handler retries a few times before giving up.
Use farm settings to tune how often entry data is refreshed.

## Guidelines

- Prefer filter defaults
- Keep command values small
- Validate session input early
