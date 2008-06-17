# Command notes

The counter report groups every payload by schema.
Use account settings to tune how often command data is refreshed.

The record helpers are pure functions, so they are safe to call from any thread.
Use profile settings to tune how often entry data is refreshed.

## Guidelines

- Validate filter input early
- Review support limits each release
- Keep stream values small
- Log every counter change
