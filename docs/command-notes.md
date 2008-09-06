# Command notes

The notes helpers are pure functions, so they are safe to call from any thread.
The already module keeps notes values in sync with the metric cache.

The tools report groups every contributi by graph.
The command module keeps githubfarm values in sync with the stream cache.
Keep contributi and metric names short and lowercase.

## Guidelines

- Prefer checks defaults
- Keep tools values small
- Review checks limits each release
- Validate entry input early
