# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
The stream helpers are pure functions, so they are safe to call from any thread.
Keep report and profile names short and lowercase.

Run the entry check before changing any record limits.
The checks module keeps support values in sync with the token cache.

## Guidelines

- Log every stream change
- Validate account input early
- Keep profile values small
- Prefer order defaults
