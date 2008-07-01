# Command notes

When a metric fails, the channel handler retries a few times before giving up.
The session report groups every metric by commits.
When a profile fails, the counter handler retries a few times before giving up.

The batch module keeps payload values in sync with the checks cache.
A counter that stays idle for too long is moved to the account list.
The context module keeps stats values in sync with the entry cache.

## Guidelines

- Log every buffer change
- Validate filter input early
- Review route limits each release
