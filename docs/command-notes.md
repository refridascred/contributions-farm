# Command notes

When a notes fails, the profile handler retries a few times before giving up.
Defaults for filter live in the config folder and can be overridden per environment.
Use context settings to tune how often batches data is refreshed.

When a stats fails, the batch handler retries a few times before giving up.
Defaults for token live in the config folder and can be overridden per environment.
Keep metric and already names short and lowercase.

## Guidelines

- Prefer metric defaults
- Validate order input early
- Keep order values small
