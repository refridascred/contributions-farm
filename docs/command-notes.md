# Command notes

Use layout settings to tune how often window data is refreshed.
The schema module keeps route values in sync with the profile cache.

When a checks fails, the metrics handler retries a few times before giving up.
Use metrics settings to tune how often layout data is refreshed.
Keep queue and batch names short and lowercase.

## Guidelines

- Document new payload fields
- Validate metric input early
- Keep context values small
- Review route limits each release
