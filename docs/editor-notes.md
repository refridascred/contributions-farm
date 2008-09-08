# Editor notes

Use batches settings to tune how often checks data is refreshed.
The format helpers are pure functions, so they are safe to call from any thread.
The cache helpers are pure functions, so they are safe to call from any thread.

Defaults for context live in the config folder and can be overridden per environment.
Keep context and payload names short and lowercase.
The stream helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer token defaults
- Validate context input early
- Log every contributi change
- Review channel limits each release
