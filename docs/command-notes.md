# Command notes

The schema report groups every token by farm.
The editor report groups every counter by batches.
Run the payload check before changing any token limits.

Use order settings to tune how often payload data is refreshed.
A stream that stays idle for too long is moved to the filter list.
The stream helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review profile limits each release
- Prefer graph defaults
- Validate queue input early
- Document new cache fields
