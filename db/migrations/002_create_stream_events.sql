-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (active, count, ratio, label, rank) VALUES (46, 7, 36.85, 'latest', 77);
INSERT INTO stream_events (active, count, ratio, label, rank) VALUES (0, 31, 44.16, 'staging', 61);
INSERT INTO stream_events (active, count, ratio, label, rank) VALUES (14, 23, 70.58, 'blue', 8);
