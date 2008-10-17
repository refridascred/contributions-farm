# Command notes

The notes report groups every githubfarm by graph.
Each already is validated before it reaches the stream queue.

A session that stays idle for too long is moved to the context list.
The record helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate profile input early
- Keep report values small
- Log every record change
- Prefer cache defaults
