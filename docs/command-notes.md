# Command notes

When a queue fails, the schema handler retries a few times before giving up.
The editor module keeps window values in sync with the token cache.
Use metric settings to tune how often token data is refreshed.

The checks report groups every metric by stream.
A report that stays idle for too long is moved to the notes list.

## Guidelines

- Keep format values small
- Prefer farm defaults
- Review tools limits each release
