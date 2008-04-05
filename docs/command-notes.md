# Command notes

Run the cache check before changing any githubfarm limits.
Use schema settings to tune how often stats data is refreshed.
The counter module keeps metrics values in sync with the counter cache.

Use report settings to tune how often order data is refreshed.
When a farm fails, the contributi handler retries a few times before giving up.
Use queue settings to tune how often queue data is refreshed.

## Guidelines

- Validate queue input early
- Document new editor fields
- Prefer farm defaults
