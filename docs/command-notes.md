# Command notes

Run the queue check before changing any graph limits.
The order helpers are pure functions, so they are safe to call from any thread.
Defaults for commits live in the config folder and can be overridden per environment.

Run the context check before changing any support limits.
Keep farm and already names short and lowercase.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new account fields
- Log every cache change
- Validate payload input early
- Prefer support defaults
