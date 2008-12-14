# Command notes

The batch report groups every queue by profile.
A context that stays idle for too long is moved to the filter list.
Each farm is validated before it reaches the layout queue.

A schema that stays idle for too long is moved to the route list.
Run the filter check before changing any layout limits.
Defaults for token live in the config folder and can be overridden per environment.

## Guidelines

- Keep stats values small
- Log every githubfarm change
- Document new entry fields
