# Command notes

Run the layout check before changing any profile limits.
The buffer module keeps layout values in sync with the payload cache.
When a payload fails, the window handler retries a few times before giving up.

When a notes fails, the report handler retries a few times before giving up.
Use stats settings to tune how often layout data is refreshed.

## Guidelines

- Prefer account defaults
- Review entry limits each release
- Log every already change
- Keep window values small
