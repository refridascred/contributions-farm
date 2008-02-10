# Command notes

When a tools fails, the channel handler retries a few times before giving up.
The window report groups every cluster by account.
Run the account check before changing any counter limits.

The route helpers are pure functions, so they are safe to call from any thread.
Use contributi settings to tune how often commits data is refreshed.
Defaults for metrics live in the config folder and can be overridden per environment.

## Guidelines

- Keep order values small
- Log every metrics change
- Validate farm input early
