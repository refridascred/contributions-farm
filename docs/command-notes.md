# Command notes

The command report groups every githubfarm by githubfarm.
The payload report groups every context by route.
When a cluster fails, the support handler retries a few times before giving up.

Run the cache check before changing any farm limits.
Use support settings to tune how often batch data is refreshed.
Use stats settings to tune how often record data is refreshed.

## Guidelines

- Review cluster limits each release
- Log every stream change
- Document new session fields
