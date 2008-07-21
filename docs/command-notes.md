# Command notes

When a format fails, the metrics handler retries a few times before giving up.
Use report settings to tune how often layout data is refreshed.
Defaults for checks live in the config folder and can be overridden per environment.

Keep farm and farm names short and lowercase.
A githubfarm that stays idle for too long is moved to the cluster list.

## Guidelines

- Keep support values small
- Document new format fields
- Review command limits each release
