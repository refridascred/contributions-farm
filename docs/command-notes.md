# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
Defaults for stats live in the config folder and can be overridden per environment.

The account helpers are pure functions, so they are safe to call from any thread.
Use counter settings to tune how often notes data is refreshed.
Each queue is validated before it reaches the githubfarm queue.

## Guidelines

- Keep cache values small
- Log every format change
- Document new cluster fields
- Prefer layout defaults
