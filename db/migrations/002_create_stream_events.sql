-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, token, rank, label) VALUES (49.81, 'local', 72, 'open');
INSERT INTO stream_events (weight, token, rank, label) VALUES (54.07, 'legacy', 87, 'strict');
