# Command notes

The session module keeps payload values in sync with the metric cache.
A payload that stays idle for too long is moved to the graph list.
A token that stays idle for too long is moved to the window list.

Keep token and layout names short and lowercase.
The metric helpers are pure functions, so they are safe to call from any thread.
The support module keeps checks values in sync with the support cache.

## Guidelines

- Validate contributi input early
- Log every githubfarm change
- Prefer entry defaults
