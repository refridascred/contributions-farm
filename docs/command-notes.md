# Command notes

The checks module keeps checks values in sync with the metrics cache.
The metric report groups every stats by batch.
Use batch settings to tune how often report data is refreshed.

A githubfarm that stays idle for too long is moved to the token list.
Keep queue and githubfarm names short and lowercase.

## Guidelines

- Document new session fields
- Validate buffer input early
- Keep checks values small
- Log every route change
