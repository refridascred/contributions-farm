# Command notes

A payload that stays idle for too long is moved to the cluster list.
When a account fails, the support handler retries a few times before giving up.

When a order fails, the metric handler retries a few times before giving up.
Defaults for counter live in the config folder and can be overridden per environment.
The entry module keeps order values in sync with the profile cache.

## Guidelines

- Validate session input early
- Log every contributi change
- Document new token fields
