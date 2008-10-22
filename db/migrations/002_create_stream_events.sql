-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    label TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (rank, owner, label, ratio, score) VALUES (41, 'primary', 'open', 92.12, 8.54);
INSERT INTO stream_events (rank, owner, label, ratio, score) VALUES (65, 'staging', 'strict', 24.24, 14.28);
