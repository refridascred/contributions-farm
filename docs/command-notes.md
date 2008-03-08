# Command notes

Each farm is validated before it reaches the cluster queue.
Defaults for payload live in the config folder and can be overridden per environment.

Each already is validated before it reaches the githubfarm queue.
The cluster report groups every filter by notes.
Use buffer settings to tune how often window data is refreshed.

## Guidelines

- Log every githubfarm change
- Keep account values small
- Prefer payload defaults
- Document new context fields
