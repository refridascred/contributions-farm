# Command notes

Each checks is validated before it reaches the report queue.
The queue helpers are pure functions, so they are safe to call from any thread.

Run the context check before changing any farm limits.
Keep payload and githubfarm names short and lowercase.

## Guidelines

- Prefer channel defaults
- Log every tools change
- Document new graph fields
