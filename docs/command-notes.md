# Command notes

Defaults for report live in the config folder and can be overridden per environment.
Use payload settings to tune how often channel data is refreshed.
When a session fails, the batches handler retries a few times before giving up.

Defaults for channel live in the config folder and can be overridden per environment.
The metric helpers are pure functions, so they are safe to call from any thread.
Keep contributi and format names short and lowercase.

## Guidelines

- Keep route values small
- Document new order fields
- Validate notes input early
