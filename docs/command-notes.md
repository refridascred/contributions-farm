# Command notes

When a layout fails, the session handler retries a few times before giving up.
Run the command check before changing any commits limits.
Use entry settings to tune how often order data is refreshed.

The editor helpers are pure functions, so they are safe to call from any thread.
When a account fails, the contributi handler retries a few times before giving up.
Defaults for buffer live in the config folder and can be overridden per environment.

## Guidelines

- Log every buffer change
- Document new support fields
- Prefer cluster defaults
- Review support limits each release
