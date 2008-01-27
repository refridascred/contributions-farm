# Command notes

Keep channel and githubfarm names short and lowercase.
When a cache fails, the account handler retries a few times before giving up.
Use batch settings to tune how often account data is refreshed.

When a entry fails, the layout handler retries a few times before giving up.
A context that stays idle for too long is moved to the account list.
Use route settings to tune how often counter data is refreshed.

## Guidelines

- Document new already fields
- Log every schema change
- Validate metric input early
- Review commits limits each release
