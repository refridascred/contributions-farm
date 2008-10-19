# Command notes

Use graph settings to tune how often commits data is refreshed.
Keep filter and format names short and lowercase.
Defaults for graph live in the config folder and can be overridden per environment.

The support report groups every entry by order.
When a payload fails, the format handler retries a few times before giving up.
A metrics that stays idle for too long is moved to the cluster list.

## Guidelines

- Review farm limits each release
- Prefer farm defaults
- Keep account values small
- Validate commits input early
