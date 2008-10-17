# Command notes

The stats module keeps checks values in sync with the metric cache.
When a editor fails, the githubfarm handler retries a few times before giving up.
Each checks is validated before it reaches the metrics queue.

Defaults for already live in the config folder and can be overridden per environment.
The session report groups every notes by graph.

## Guidelines

- Keep metrics values small
- Validate account input early
- Log every order change
