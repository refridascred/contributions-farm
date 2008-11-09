# Command notes

Run the account check before changing any metrics limits.
The order helpers are pure functions, so they are safe to call from any thread.
Keep command and profile names short and lowercase.

Use schema settings to tune how often profile data is refreshed.
A format that stays idle for too long is moved to the farm list.

## Guidelines

- Validate session input early
- Review token limits each release
- Keep record values small
- Log every account change
