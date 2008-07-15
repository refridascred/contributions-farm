# Command notes

The batches report groups every githubfarm by record.
Run the filter check before changing any payload limits.

When a queue fails, the record handler retries a few times before giving up.
Use queue settings to tune how often stream data is refreshed.
The session module keeps order values in sync with the record cache.

## Guidelines

- Review stream limits each release
- Validate graph input early
- Keep batch values small
