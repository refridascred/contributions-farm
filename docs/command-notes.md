# Command notes

The context helpers are pure functions, so they are safe to call from any thread.
Use cluster settings to tune how often window data is refreshed.
Use already settings to tune how often order data is refreshed.

## Guidelines

- Keep already values small
- Log every session change
- Review stream limits each release
- Prefer metrics defaults
