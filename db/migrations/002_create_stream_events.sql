-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (active, label, rank, score) VALUES (72, 'fallback', 98, 93.57);
INSERT INTO stream_events (active, label, rank, score) VALUES (99, 'latest', 31, 46.83);
INSERT INTO stream_events (active, label, rank, score) VALUES (82, 'eu-west', 24, 0.54);
