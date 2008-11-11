# Command notes

Defaults for metric live in the config folder and can be overridden per environment.
Use queue settings to tune how often tools data is refreshed.

When a editor fails, the filter handler retries a few times before giving up.
Keep cluster and channel names short and lowercase.

## Guidelines

- Keep checks values small
- Document new report fields
- Prefer stats defaults
- Log every batch change
