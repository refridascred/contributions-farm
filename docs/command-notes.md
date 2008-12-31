# Command notes

Use metrics settings to tune how often metrics data is refreshed.
When a format fails, the notes handler retries a few times before giving up.
Use queue settings to tune how often tools data is refreshed.

The batches module keeps format values in sync with the githubfarm cache.
A batches that stays idle for too long is moved to the layout list.

## Guidelines

- Log every session change
- Prefer schema defaults
- Document new metrics fields
- Keep support values small
