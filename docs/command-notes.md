# Command notes

Run the metrics check before changing any context limits.
The layout helpers are pure functions, so they are safe to call from any thread.

The stats module keeps stats values in sync with the checks cache.
Keep githubfarm and session names short and lowercase.
Defaults for entry live in the config folder and can be overridden per environment.

## Guidelines

- Review stream limits each release
- Keep batch values small
- Validate account input early
- Log every support change
