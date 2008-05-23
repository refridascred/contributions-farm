# Command notes

Each batch is validated before it reaches the payload queue.
The channel report groups every counter by farm.
A support that stays idle for too long is moved to the record list.

When a schema fails, the contributi handler retries a few times before giving up.
Use buffer settings to tune how often cache data is refreshed.
Defaults for contributi live in the config folder and can be overridden per environment.

## Guidelines

- Document new filter fields
- Prefer notes defaults
- Validate buffer input early
- Keep channel values small
