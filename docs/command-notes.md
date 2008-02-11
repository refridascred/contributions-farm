# Command notes

Each counter is validated before it reaches the tools queue.
Each context is validated before it reaches the farm queue.
The tools helpers are pure functions, so they are safe to call from any thread.

Use format settings to tune how often stats data is refreshed.
The stats report groups every layout by command.

## Guidelines

- Document new metric fields
- Review notes limits each release
- Log every queue change
- Keep buffer values small
