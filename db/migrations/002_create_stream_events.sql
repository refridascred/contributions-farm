-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (count, weight, label, rank, score) VALUES (10, 7.17, 'green', 68, 22.62);
INSERT INTO stream_events (count, weight, label, rank, score) VALUES (54, 56.01, 'fallback', 31, 12.21);
INSERT INTO stream_events (count, weight, label, rank, score) VALUES (27, 40.46, 'legacy', 17, 1.37);
