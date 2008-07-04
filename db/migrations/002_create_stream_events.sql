-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (ratio, score, label, rank) VALUES (91.41, 61.61, 'open', 78);
INSERT INTO stream_events (ratio, score, label, rank) VALUES (45.33, 49.45, 'primary', 52);
