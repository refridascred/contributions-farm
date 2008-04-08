-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (owner, rank, label, score) VALUES ('open', 88, 'latest', 26.93);
INSERT INTO stream_events (owner, rank, label, score) VALUES ('legacy', 39, 'edge', 25.63);
INSERT INTO stream_events (owner, rank, label, score) VALUES ('edge', 86, 'fallback', 67.86);
