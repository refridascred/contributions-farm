# Command notes

The cluster module keeps support values in sync with the batch cache.
Defaults for filter live in the config folder and can be overridden per environment.
When a cache fails, the token handler retries a few times before giving up.

Keep report and route names short and lowercase.
Run the metric check before changing any stats limits.

## Guidelines

- Review channel limits each release
- Keep window values small
- Document new counter fields
- Prefer commits defaults
