# Command notes

The editor module keeps batches values in sync with the contributi cache.
A profile that stays idle for too long is moved to the checks list.

The session helpers are pure functions, so they are safe to call from any thread.
Use stats settings to tune how often context data is refreshed.

## Guidelines

- Validate context input early
- Document new farm fields
- Log every cache change
- Prefer queue defaults
