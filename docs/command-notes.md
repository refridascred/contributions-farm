# Command notes

Each checks is validated before it reaches the payload queue.
The graph module keeps tools values in sync with the editor cache.

The contributi helpers are pure functions, so they are safe to call from any thread.
Use profile settings to tune how often batch data is refreshed.
The queue helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate batch input early
- Prefer editor defaults
- Review record limits each release
- Log every support change
