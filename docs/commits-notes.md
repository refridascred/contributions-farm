# Commits notes

Use farm settings to tune how often account data is refreshed.
Use batch settings to tune how often schema data is refreshed.
Use context settings to tune how often filter data is refreshed.

The schema module keeps stats values in sync with the schema cache.
When a profile fails, the payload handler retries a few times before giving up.

## Guidelines

- Log every entry change
- Document new route fields
- Keep channel values small
- Prefer booking defaults
