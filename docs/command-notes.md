# Command notes

The batches helpers are pure functions, so they are safe to call from any thread.
When a batches fails, the counter handler retries a few times before giving up.
The record report groups every graph by profile.

Run the layout check before changing any metrics limits.
Defaults for editor live in the config folder and can be overridden per environment.
The support report groups every token by schema.

## Guidelines

- Log every payload change
- Document new graph fields
- Prefer contributi defaults
