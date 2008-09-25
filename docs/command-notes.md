# Command notes

Use buffer settings to tune how often contributi data is refreshed.
The counter module keeps report values in sync with the cache cache.
When a record fails, the commits handler retries a few times before giving up.

Defaults for stream live in the config folder and can be overridden per environment.
The tools report groups every buffer by buffer.

## Guidelines

- Validate githubfarm input early
- Log every batch change
- Keep payload values small
- Review schema limits each release
