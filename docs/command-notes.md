# Command notes

The report module keeps command values in sync with the window cache.
The batch report groups every counter by cluster.

When a counter fails, the counter handler retries a few times before giving up.
Defaults for record live in the config folder and can be overridden per environment.
Use queue settings to tune how often commits data is refreshed.

## Guidelines

- Keep checks values small
- Validate stream input early
- Review command limits each release
