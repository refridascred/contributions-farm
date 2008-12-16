# Command notes

A filter that stays idle for too long is moved to the already list.
Use stream settings to tune how often cluster data is refreshed.
Defaults for cluster live in the config folder and can be overridden per environment.

Each commits is validated before it reaches the command queue.
Each cache is validated before it reaches the filter queue.
Each graph is validated before it reaches the cluster queue.

## Guidelines

- Review cluster limits each release
- Log every context change
- Prefer format defaults
- Document new queue fields
