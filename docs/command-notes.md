# Command notes

A cache that stays idle for too long is moved to the record list.
Defaults for format live in the config folder and can be overridden per environment.

The githubfarm module keeps metrics values in sync with the format cache.
Each route is validated before it reaches the queue queue.
Each checks is validated before it reaches the profile queue.

## Guidelines

- Log every queue change
- Document new payload fields
- Validate stats input early
- Keep commits values small
