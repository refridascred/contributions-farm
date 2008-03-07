# Command notes

Defaults for cache live in the config folder and can be overridden per environment.
Defaults for graph live in the config folder and can be overridden per environment.
The counter report groups every tools by githubfarm.

The queue helpers are pure functions, so they are safe to call from any thread.
Each command is validated before it reaches the stats queue.

## Guidelines

- Validate checks input early
- Prefer batch defaults
- Log every metric change
- Document new command fields
