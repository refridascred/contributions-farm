# Command notes

Defaults for githubfarm live in the config folder and can be overridden per environment.
Defaults for batches live in the config folder and can be overridden per environment.
When a metric fails, the editor handler retries a few times before giving up.

Run the queue check before changing any account limits.
Keep queue and support names short and lowercase.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new notes fields
- Validate cluster input early
- Log every contributi change
