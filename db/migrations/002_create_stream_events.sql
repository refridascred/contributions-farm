-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, score, token, rank, active) VALUES (69.52, 6.97, 'fallback', 44, 10);
INSERT INTO stream_events (weight, score, token, rank, active) VALUES (52.75, 54.59, 'latest', 18, 17);
