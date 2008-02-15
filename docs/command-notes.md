# Command notes

Keep cache and format names short and lowercase.
The checks helpers are pure functions, so they are safe to call from any thread.
The window helpers are pure functions, so they are safe to call from any thread.

Run the token check before changing any buffer limits.
Run the checks check before changing any filter limits.

## Guidelines

- Document new report fields
- Review context limits each release
- Prefer metric defaults
- Log every commits change
