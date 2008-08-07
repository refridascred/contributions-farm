# Command notes

The counter module keeps batches values in sync with the tools cache.
When a format fails, the metrics handler retries a few times before giving up.
Defaults for profile live in the config folder and can be overridden per environment.

Run the queue check before changing any route limits.
A counter that stays idle for too long is moved to the checks list.
The entry module keeps context values in sync with the order cache.

## Guidelines

- Log every session change
- Review token limits each release
- Document new profile fields
