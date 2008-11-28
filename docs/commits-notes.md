# Commits notes

Run the command check before changing any tools limits.
Keep window and stream names short and lowercase.
Keep context and layout names short and lowercase.

The farm helpers are pure functions, so they are safe to call from any thread.
Keep farm and schema names short and lowercase.
Defaults for profile live in the config folder and can be overridden per environment.

## Guidelines

- Review metrics limits each release
- Log every schema change
- Prefer stats defaults
- Keep batch values small
