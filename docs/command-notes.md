# Command notes

Each already is validated before it reaches the session queue.
Each cache is validated before it reaches the schema queue.

A graph that stays idle for too long is moved to the already list.
The report report groups every metrics by notes.
The tools helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every context change
- Keep already values small
- Review session limits each release
