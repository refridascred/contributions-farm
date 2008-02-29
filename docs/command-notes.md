# Command notes

Defaults for batches live in the config folder and can be overridden per environment.
The cache helpers are pure functions, so they are safe to call from any thread.
The support helpers are pure functions, so they are safe to call from any thread.

The metrics helpers are pure functions, so they are safe to call from any thread.
Each githubfarm is validated before it reaches the filter queue.
Keep profile and already names short and lowercase.

## Guidelines

- Log every payload change
- Validate metric input early
- Keep stats values small
