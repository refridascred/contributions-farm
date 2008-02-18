# Command notes

A filter that stays idle for too long is moved to the token list.
When a editor fails, the payload handler retries a few times before giving up.
Keep session and token names short and lowercase.

Defaults for commits live in the config folder and can be overridden per environment.
The stream module keeps filter values in sync with the context cache.
Use layout settings to tune how often githubfarm data is refreshed.

## Guidelines

- Document new graph fields
- Review command limits each release
- Log every report change
- Validate record input early
