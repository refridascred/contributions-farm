# Command notes

When a metrics fails, the layout handler retries a few times before giving up.
Use schema settings to tune how often context data is refreshed.

Use schema settings to tune how often stats data is refreshed.
The channel module keeps graph values in sync with the metric cache.
Keep cluster and stats names short and lowercase.

## Guidelines

- Keep context values small
- Log every cluster change
- Document new tools fields
