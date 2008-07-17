# Command notes

Run the graph check before changing any support limits.
When a commits fails, the batch handler retries a few times before giving up.
The schema module keeps farm values in sync with the report cache.

## Guidelines

- Document new command fields
- Validate commits input early
- Review commits limits each release
- Keep cluster values small
