# Command notes

Run the buffer check before changing any context limits.
Defaults for checks live in the config folder and can be overridden per environment.
Defaults for farm live in the config folder and can be overridden per environment.

Keep githubfarm and payload names short and lowercase.
Each already is validated before it reaches the batches queue.

## Guidelines

- Prefer cache defaults
- Validate route input early
- Log every metrics change
