# Command notes

The tools report groups every report by batch.
Run the editor check before changing any route limits.
When a contributi fails, the stats handler retries a few times before giving up.

The checks helpers are pure functions, so they are safe to call from any thread.
Keep cache and profile names short and lowercase.
The githubfarm module keeps record values in sync with the entry cache.

## Guidelines

- Keep channel values small
- Log every layout change
- Review stats limits each release
- Prefer session defaults
