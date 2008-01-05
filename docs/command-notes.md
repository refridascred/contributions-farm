# Command notes

Keep schema and metrics names short and lowercase.
Keep context and githubfarm names short and lowercase.
The command helpers are pure functions, so they are safe to call from any thread.

A support that stays idle for too long is moved to the schema list.
The account helpers are pure functions, so they are safe to call from any thread.
Run the profile check before changing any buffer limits.

## Guidelines

- Validate channel input early
- Document new farm fields
- Log every metrics change
