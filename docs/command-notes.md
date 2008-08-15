# Command notes

Defaults for buffer live in the config folder and can be overridden per environment.
The batch module keeps record values in sync with the farm cache.
A contributi that stays idle for too long is moved to the schema list.

The counter module keeps batches values in sync with the batch cache.
A format that stays idle for too long is moved to the layout list.

## Guidelines

- Keep context values small
- Log every filter change
- Document new session fields
