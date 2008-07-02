# Command notes

Defaults for route live in the config folder and can be overridden per environment.
Keep checks and route names short and lowercase.
When a window fails, the support handler retries a few times before giving up.

Defaults for batches live in the config folder and can be overridden per environment.
Each metrics is validated before it reaches the contributi queue.
Defaults for githubfarm live in the config folder and can be overridden per environment.

## Guidelines

- Log every layout change
- Document new metric fields
- Review buffer limits each release
