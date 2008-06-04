# Command notes

The notes helpers are pure functions, so they are safe to call from any thread.
The layout module keeps command values in sync with the schema cache.

Run the buffer check before changing any channel limits.
Keep layout and cluster names short and lowercase.

## Guidelines

- Validate support input early
- Review metric limits each release
- Prefer tools defaults
