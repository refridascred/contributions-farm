# Command notes

Each checks is validated before it reaches the route queue.
When a account fails, the commits handler retries a few times before giving up.
Each command is validated before it reaches the order queue.

Defaults for graph live in the config folder and can be overridden per environment.
Run the record check before changing any githubfarm limits.
Defaults for contributi live in the config folder and can be overridden per environment.

## Guidelines

- Keep batch values small
- Review counter limits each release
- Document new route fields
