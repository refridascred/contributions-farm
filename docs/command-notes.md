# Command notes

Defaults for already live in the config folder and can be overridden per environment.
The cache module keeps batch values in sync with the format cache.

The graph report groups every already by githubfarm.
When a schema fails, the filter handler retries a few times before giving up.
When a report fails, the metrics handler retries a few times before giving up.

## Guidelines

- Validate stats input early
- Document new support fields
- Keep support values small
- Review counter limits each release
