# Command notes

The metrics module keeps already values in sync with the cluster cache.
Use profile settings to tune how often context data is refreshed.
Defaults for queue live in the config folder and can be overridden per environment.

Each report is validated before it reaches the metrics queue.
Each checks is validated before it reaches the profile queue.
A farm that stays idle for too long is moved to the route list.

## Guidelines

- Document new queue fields
- Keep context values small
- Review profile limits each release
- Log every profile change
