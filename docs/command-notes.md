# Command notes

Use metrics settings to tune how often account data is refreshed.
When a metrics fails, the githubfarm handler retries a few times before giving up.
When a context fails, the cache handler retries a few times before giving up.

When a account fails, the route handler retries a few times before giving up.
Use editor settings to tune how often githubfarm data is refreshed.
Keep report and checks names short and lowercase.

## Guidelines

- Validate notes input early
- Log every format change
- Document new entry fields
