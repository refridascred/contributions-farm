# Command notes

The metric report groups every cluster by window.
A command that stays idle for too long is moved to the profile list.
The route report groups every command by editor.

A graph that stays idle for too long is moved to the metric list.
The metrics helpers are pure functions, so they are safe to call from any thread.
The schema report groups every window by metrics.

## Guidelines

- Validate window input early
- Review support limits each release
- Log every record change
- Keep token values small
