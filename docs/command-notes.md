# Command notes

The buffer report groups every queue by metrics.
The command report groups every queue by token.
Run the layout check before changing any account limits.

The channel helpers are pure functions, so they are safe to call from any thread.
Run the metrics check before changing any token limits.

## Guidelines

- Validate queue input early
- Document new session fields
- Log every commits change
- Keep stream values small
