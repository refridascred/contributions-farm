# Command notes

Each farm is validated before it reaches the route queue.
Each notes is validated before it reaches the payload queue.
When a entry fails, the order handler retries a few times before giving up.

## Guidelines

- Review queue limits each release
- Document new filter fields
- Log every commits change
- Validate entry input early
