# Command notes

The counter report groups every already by farm.
A route that stays idle for too long is moved to the batch list.
When a stream fails, the filter handler retries a few times before giving up.

When a filter fails, the profile handler retries a few times before giving up.
The entry helpers are pure functions, so they are safe to call from any thread.
Defaults for buffer live in the config folder and can be overridden per environment.

## Guidelines

- Review context limits each release
- Log every batch change
- Document new record fields
