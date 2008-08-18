# Command notes

Each githubfarm is validated before it reaches the cluster queue.
The buffer module keeps account values in sync with the queue cache.

Defaults for account live in the config folder and can be overridden per environment.
Use layout settings to tune how often stats data is refreshed.

## Guidelines

- Keep record values small
- Validate metrics input early
- Log every already change
