# Command notes

When a githubfarm fails, the editor handler retries a few times before giving up.
A record that stays idle for too long is moved to the githubfarm list.
Each format is validated before it reaches the window queue.

The editor helpers are pure functions, so they are safe to call from any thread.
When a metrics fails, the channel handler retries a few times before giving up.
Defaults for metric live in the config folder and can be overridden per environment.

## Guidelines

- Prefer stream defaults
- Log every stats change
- Validate payload input early
