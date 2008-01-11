-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (score, count, rank, active) VALUES (54.22, 96, 92, 84);
INSERT INTO stream_events (score, count, rank, active) VALUES (60.7, 33, 37, 35);
INSERT INTO stream_events (score, count, rank, active) VALUES (52.71, 18, 66, 53);
