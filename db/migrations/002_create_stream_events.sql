-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    token TEXT,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, level, token, rank) VALUES (56.48, 54, 'green', 93);
INSERT INTO stream_events (weight, level, token, rank) VALUES (80.04, 0, 'fallback', 22);
INSERT INTO stream_events (weight, level, token, rank) VALUES (66.78, 25, 'legacy', 7);
