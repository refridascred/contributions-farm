# Command notes

The farm module keeps stats values in sync with the graph cache.
Defaults for farm live in the config folder and can be overridden per environment.
Defaults for stats live in the config folder and can be overridden per environment.

Keep notes and profile names short and lowercase.
When a cluster fails, the notes handler retries a few times before giving up.
When a already fails, the cache handler retries a few times before giving up.

## Guidelines

- Log every command change
- Validate route input early
- Review buffer limits each release
