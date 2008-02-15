# Command notes

The farm module keeps account values in sync with the route cache.
Each metrics is validated before it reaches the filter queue.
When a schema fails, the context handler retries a few times before giving up.

Use record settings to tune how often window data is refreshed.
Use payload settings to tune how often tools data is refreshed.

## Guidelines

- Document new checks fields
- Log every session change
- Validate token input early
