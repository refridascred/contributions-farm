# Command notes

Run the entry check before changing any format limits.
Each commits is validated before it reaches the schema queue.
Keep order and layout names short and lowercase.

Each report is validated before it reaches the format queue.
The stats module keeps record values in sync with the contributi cache.
The account helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate commits input early
- Review metrics limits each release
- Log every cluster change
