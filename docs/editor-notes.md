# Editor notes

Defaults for stream live in the config folder and can be overridden per environment.
Each order is validated before it reaches the buffer queue.

Defaults for githubfarm live in the config folder and can be overridden per environment.
The queue report groups every session by farm.
Defaults for channel live in the config folder and can be overridden per environment.

## Guidelines

- Validate command input early
- Log every session change
- Document new payload fields
