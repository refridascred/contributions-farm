# Command notes

Keep notes and payload names short and lowercase.
Use profile settings to tune how often cache data is refreshed.

The tools helpers are pure functions, so they are safe to call from any thread.
A filter that stays idle for too long is moved to the token list.

## Guidelines

- Log every token change
- Review batch limits each release
- Prefer already defaults
- Validate graph input early
