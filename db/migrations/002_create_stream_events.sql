-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, score, rank, label, owner) VALUES (16, 90.19, 50, 'primary', 'primary');
INSERT INTO stream_events (count, score, rank, label, owner) VALUES (86, 32.24, 35, 'edge', 'legacy');
