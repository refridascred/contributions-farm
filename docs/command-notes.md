# Command notes

The graph report groups every contributi by window.
When a report fails, the graph handler retries a few times before giving up.
Each session is validated before it reaches the order queue.

Use checks settings to tune how often profile data is refreshed.
Defaults for order live in the config folder and can be overridden per environment.

## Guidelines

- Review profile limits each release
- Validate metrics input early
- Prefer graph defaults
- Log every report change
