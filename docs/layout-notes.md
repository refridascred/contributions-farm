# Layout notes

The batch helpers are pure functions, so they are safe to call from any thread.
Use booking settings to tune how often token data is refreshed.

## Guidelines

- Validate context input early
- Prefer window defaults
- Keep commits values small
