# Command notes

Defaults for stats live in the config folder and can be overridden per environment.
The stream module keeps editor values in sync with the counter cache.
When a schema fails, the report handler retries a few times before giving up.

The route report groups every stats by report.
A stream that stays idle for too long is moved to the batches list.

## Guidelines

- Prefer batch defaults
- Keep token values small
- Document new githubfarm fields
- Review account limits each release
