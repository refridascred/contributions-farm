# Command notes

Each tools is validated before it reaches the order queue.
Run the filter check before changing any schema limits.

The counter helpers are pure functions, so they are safe to call from any thread.
Defaults for githubfarm live in the config folder and can be overridden per environment.
The support report groups every account by graph.

## Guidelines

- Document new context fields
- Prefer support defaults
- Review payload limits each release
