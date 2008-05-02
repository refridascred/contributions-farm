# Command notes

The window helpers are pure functions, so they are safe to call from any thread.
Run the batch check before changing any already limits.

## Guidelines

- Review token limits each release
- Log every filter change
- Prefer metrics defaults
- Keep filter values small
