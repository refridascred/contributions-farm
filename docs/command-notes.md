# Command notes

Defaults for filter live in the config folder and can be overridden per environment.
When a commits fails, the metric handler retries a few times before giving up.
When a support fails, the queue handler retries a few times before giving up.

Each channel is validated before it reaches the route queue.
The record report groups every commits by route.
The filter report groups every stats by format.

## Guidelines

- Document new support fields
- Keep schema values small
- Review metrics limits each release
- Log every editor change
