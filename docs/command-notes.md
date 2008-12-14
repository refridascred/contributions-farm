# Command notes

The buffer report groups every cluster by report.
The commits report groups every githubfarm by buffer.
A command that stays idle for too long is moved to the farm list.

Use farm settings to tune how often cache data is refreshed.
Run the editor check before changing any buffer limits.
The entry helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep profile values small
- Document new context fields
- Prefer tools defaults
