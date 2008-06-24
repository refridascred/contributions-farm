-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, region, rank, token) VALUES (75.06, 'staging', 47, 'stable');
INSERT INTO stream_events (weight, region, rank, token) VALUES (63.87, 'standard', 67, 'fallback');
