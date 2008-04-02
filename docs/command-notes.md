# Command notes

Each route is validated before it reaches the entry queue.
Defaults for tools live in the config folder and can be overridden per environment.

Each layout is validated before it reaches the githubfarm queue.
When a editor fails, the context handler retries a few times before giving up.
The farm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep route values small
- Review token limits each release
- Prefer schema defaults
- Document new tools fields
