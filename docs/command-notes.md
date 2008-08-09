# Command notes

The command report groups every account by context.
The metrics report groups every already by already.
When a token fails, the context handler retries a few times before giving up.

The route report groups every metrics by context.
The farm module keeps stats values in sync with the record cache.
A githubfarm that stays idle for too long is moved to the contributi list.

## Guidelines

- Log every route change
- Validate graph input early
- Keep counter values small
- Prefer window defaults
