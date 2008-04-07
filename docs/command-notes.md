# Command notes

The payload report groups every buffer by account.
Keep token and format names short and lowercase.
Use already settings to tune how often counter data is refreshed.

Keep context and entry names short and lowercase.
The metrics module keeps session values in sync with the order cache.
The stream helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer metrics defaults
- Log every layout change
- Validate commits input early
- Review stats limits each release
