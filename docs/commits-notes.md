# Commits notes

The stream module keeps stats values in sync with the batch cache.
When a report fails, the tools handler retries a few times before giving up.
Use stream settings to tune how often layout data is refreshed.

## Guidelines

- Log every channel change
- Keep graph values small
- Document new stats fields
- Review order limits each release
