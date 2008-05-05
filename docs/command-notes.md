# Command notes

Run the payload check before changing any stream limits.
Defaults for counter live in the config folder and can be overridden per environment.
Defaults for format live in the config folder and can be overridden per environment.

A profile that stays idle for too long is moved to the entry list.
Each counter is validated before it reaches the order queue.
A report that stays idle for too long is moved to the githubfarm list.

## Guidelines

- Document new already fields
- Keep session values small
- Review metrics limits each release
- Log every window change
