-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, rank, region, active, token) VALUES (8.35, 12, 'latest', 78, 'strict');
INSERT INTO stream_events (weight, rank, region, active, token) VALUES (0.77, 64, 'eu-west', 24, 'legacy');
