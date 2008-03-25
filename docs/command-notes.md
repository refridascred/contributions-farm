# Command notes

Each layout is validated before it reaches the cache queue.
Each support is validated before it reaches the support queue.
The entry module keeps channel values in sync with the stats cache.

Keep metrics and payload names short and lowercase.
The already helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer githubfarm defaults
- Document new profile fields
- Keep filter values small
