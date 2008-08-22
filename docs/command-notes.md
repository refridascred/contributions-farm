# Command notes

Run the context check before changing any queue limits.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

Run the command check before changing any notes limits.
Keep schema and order names short and lowercase.

## Guidelines

- Validate route input early
- Keep stats values small
- Log every command change
- Document new report fields
