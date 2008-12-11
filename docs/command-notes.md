# Command notes

Use stats settings to tune how often payload data is refreshed.
The cluster module keeps route values in sync with the payload cache.

Use metrics settings to tune how often order data is refreshed.
When a metrics fails, the record handler retries a few times before giving up.
Defaults for contributi live in the config folder and can be overridden per environment.

## Guidelines

- Review schema limits each release
- Keep schema values small
- Document new filter fields
