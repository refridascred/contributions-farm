# Command notes

A counter that stays idle for too long is moved to the context list.
Each farm is validated before it reaches the buffer queue.
The checks module keeps batches values in sync with the entry cache.

Defaults for metrics live in the config folder and can be overridden per environment.
Keep window and context names short and lowercase.

## Guidelines

- Keep contributi values small
- Document new checks fields
- Review farm limits each release
- Log every window change
