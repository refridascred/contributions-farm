# Command notes

A stream that stays idle for too long is moved to the editor list.
The githubfarm module keeps contributi values in sync with the githubfarm cache.
The entry report groups every contributi by stream.

Each notes is validated before it reaches the graph queue.
The profile helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new layout fields
- Log every payload change
- Keep notes values small
- Review stats limits each release
