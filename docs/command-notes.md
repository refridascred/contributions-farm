# Command notes

The queue report groups every contributi by layout.
When a metrics fails, the cluster handler retries a few times before giving up.

When a account fails, the report handler retries a few times before giving up.
Use entry settings to tune how often githubfarm data is refreshed.
Defaults for commits live in the config folder and can be overridden per environment.

## Guidelines

- Document new checks fields
- Keep commits values small
- Review record limits each release
