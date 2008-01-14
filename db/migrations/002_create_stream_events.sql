-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (score, weight, rank) VALUES (28.62, 22.73, 83);
INSERT INTO stream_events (score, weight, rank) VALUES (17.4, 8.38, 89);
INSERT INTO stream_events (score, weight, rank) VALUES (68.45, 74.02, 63);
