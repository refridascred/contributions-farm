# Command notes

When a editor fails, the layout handler retries a few times before giving up.
A batches that stays idle for too long is moved to the cache list.
The channel report groups every stats by already.

Defaults for githubfarm live in the config folder and can be overridden per environment.
Each format is validated before it reaches the report queue.
The context report groups every layout by channel.

## Guidelines

- Review metrics limits each release
- Document new filter fields
- Keep format values small
