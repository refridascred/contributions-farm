# Commits notes

Run the stats check before changing any token limits.
The entry helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate batch input early
- Keep window values small
- Log every account change
