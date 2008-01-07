# Command notes

The context report groups every layout by session.
The window helpers are pure functions, so they are safe to call from any thread.
Run the layout check before changing any profile limits.

A stream that stays idle for too long is moved to the entry list.
The stats module keeps report values in sync with the stats cache.
Each command is validated before it reaches the tools queue.

## Guidelines

- Document new batches fields
- Keep queue values small
- Log every githubfarm change
