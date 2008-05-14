-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (count, token, rank, weight, region) VALUES (40, 'green', 51, 47.18, 'stable');
INSERT INTO stream_events (count, token, rank, weight, region) VALUES (55, 'legacy', 33, 94.52, 'strict');
