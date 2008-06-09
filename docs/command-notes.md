# Command notes

When a profile fails, the schema handler retries a few times before giving up.
The cache report groups every order by queue.
The stats module keeps stream values in sync with the metrics cache.

Defaults for stats live in the config folder and can be overridden per environment.
The channel module keeps account values in sync with the layout cache.
A route that stays idle for too long is moved to the window list.

## Guidelines

- Validate batches input early
- Keep filter values small
- Document new profile fields
