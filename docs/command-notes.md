# Command notes

Use graph settings to tune how often tools data is refreshed.
The stats module keeps filter values in sync with the route cache.

Use route settings to tune how often account data is refreshed.
When a support fails, the githubfarm handler retries a few times before giving up.
When a metrics fails, the record handler retries a few times before giving up.

## Guidelines

- Log every counter change
- Document new stats fields
- Review token limits each release
