# Command notes

Use farm settings to tune how often channel data is refreshed.
A format that stays idle for too long is moved to the stream list.
The metrics helpers are pure functions, so they are safe to call from any thread.

Run the tools check before changing any support limits.
The tools helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every queue change
- Validate batches input early
- Prefer account defaults
