# Command notes

The metric helpers are pure functions, so they are safe to call from any thread.
A layout that stays idle for too long is moved to the commits list.
A entry that stays idle for too long is moved to the metrics list.

Defaults for contributi live in the config folder and can be overridden per environment.
Each layout is validated before it reaches the session queue.

## Guidelines

- Document new checks fields
- Review support limits each release
- Prefer githubfarm defaults
