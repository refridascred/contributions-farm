# Command notes

Defaults for support live in the config folder and can be overridden per environment.
The report module keeps checks values in sync with the stats cache.
A checks that stays idle for too long is moved to the metrics list.

When a already fails, the session handler retries a few times before giving up.
Each contributi is validated before it reaches the schema queue.
Keep command and counter names short and lowercase.

## Guidelines

- Prefer profile defaults
- Document new graph fields
- Validate entry input early
