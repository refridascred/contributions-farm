# Command notes

Use layout settings to tune how often buffer data is refreshed.
The context report groups every payload by channel.
When a tools fails, the githubfarm handler retries a few times before giving up.

The checks report groups every stream by account.
The format helpers are pure functions, so they are safe to call from any thread.
Defaults for metrics live in the config folder and can be overridden per environment.

## Guidelines

- Document new session fields
- Log every batches change
- Validate graph input early
