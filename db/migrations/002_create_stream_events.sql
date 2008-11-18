-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (score, rank) VALUES (10.63, 67);
INSERT INTO stream_events (score, rank) VALUES (80.5, 93);
INSERT INTO stream_events (score, rank) VALUES (39.31, 55);
