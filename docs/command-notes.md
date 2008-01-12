# Command notes

Keep cluster and buffer names short and lowercase.
Each contributi is validated before it reaches the session queue.
A graph that stays idle for too long is moved to the metric list.

Use counter settings to tune how often graph data is refreshed.
A record that stays idle for too long is moved to the stream list.
The window helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new profile fields
- Prefer command defaults
- Log every format change
- Keep record values small
