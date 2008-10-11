# Command notes

The layout helpers are pure functions, so they are safe to call from any thread.
Run the context check before changing any report limits.
Keep checks and session names short and lowercase.

## Guidelines

- Log every entry change
- Review filter limits each release
- Validate order input early
