# Command notes

The schema report groups every cluster by already.
Keep contributi and command names short and lowercase.
Use context settings to tune how often queue data is refreshed.

Defaults for batches live in the config folder and can be overridden per environment.
The githubfarm helpers are pure functions, so they are safe to call from any thread.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new channel fields
- Validate layout input early
- Prefer queue defaults
