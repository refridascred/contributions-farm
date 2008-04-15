# Command notes

Defaults for cache live in the config folder and can be overridden per environment.
A tools that stays idle for too long is moved to the cluster list.
When a buffer fails, the metric handler retries a few times before giving up.

A contributi that stays idle for too long is moved to the profile list.
Each contributi is validated before it reaches the cluster queue.
The report report groups every layout by account.

## Guidelines

- Validate schema input early
- Review format limits each release
- Log every queue change
