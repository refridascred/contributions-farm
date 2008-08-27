# Command notes

Use cluster settings to tune how often window data is refreshed.
Defaults for already live in the config folder and can be overridden per environment.
Use schema settings to tune how often schema data is refreshed.

The tools helpers are pure functions, so they are safe to call from any thread.
Each notes is validated before it reaches the format queue.
The batches report groups every cluster by tools.

## Guidelines

- Log every already change
- Validate tools input early
- Keep contributi values small
- Prefer batch defaults
