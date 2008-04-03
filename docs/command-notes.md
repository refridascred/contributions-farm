# Command notes

Run the editor check before changing any cache limits.
The editor helpers are pure functions, so they are safe to call from any thread.
Each format is validated before it reaches the metrics queue.

## Guidelines

- Prefer editor defaults
- Review support limits each release
- Log every contributi change
- Document new report fields
