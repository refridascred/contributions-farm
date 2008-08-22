# Command notes

Run the command check before changing any metric limits.
Use record settings to tune how often profile data is refreshed.
The payload module keeps command values in sync with the metrics cache.

The payload report groups every report by payload.
The record report groups every notes by stats.
Defaults for batches live in the config folder and can be overridden per environment.

## Guidelines

- Review metrics limits each release
- Keep schema values small
- Validate stream input early
