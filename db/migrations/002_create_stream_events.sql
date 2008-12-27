-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (count, rank, label, score) VALUES (55, 14, 'standard', 41.01);
INSERT INTO stream_events (count, rank, label, score) VALUES (38, 24, 'legacy', 3.88);
INSERT INTO stream_events (count, rank, label, score) VALUES (10, 85, 'primary', 37.99);
