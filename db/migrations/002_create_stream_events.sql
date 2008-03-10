-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, token, label) VALUES (31.96, 'blue', 'strict');
INSERT INTO stream_events (weight, token, label) VALUES (12.89, 'latest', 'legacy');
