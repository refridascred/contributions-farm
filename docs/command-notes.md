# Command notes

The filter report groups every record by farm.
A stream that stays idle for too long is moved to the schema list.

The entry helpers are pure functions, so they are safe to call from any thread.
The window helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every metric change
- Keep payload values small
- Validate buffer input early
- Document new payload fields
