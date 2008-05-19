# Command notes

Each profile is validated before it reaches the channel queue.
Each githubfarm is validated before it reaches the route queue.
A contributi that stays idle for too long is moved to the notes list.

Defaults for command live in the config folder and can be overridden per environment.
Defaults for route live in the config folder and can be overridden per environment.
Keep channel and route names short and lowercase.

## Guidelines

- Review order limits each release
- Document new batches fields
- Prefer cache defaults
