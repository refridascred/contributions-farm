# Command notes

Each githubfarm is validated before it reaches the route queue.
Use graph settings to tune how often stats data is refreshed.

Run the metric check before changing any batch limits.
A githubfarm that stays idle for too long is moved to the editor list.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer queue defaults
- Document new buffer fields
- Keep window values small
- Validate contributi input early
