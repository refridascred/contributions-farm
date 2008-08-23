-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    region TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (rank, label, region, ratio, owner) VALUES (52, 'green', 'latest', 69.43, 'fallback');
INSERT INTO stream_events (rank, label, region, ratio, owner) VALUES (75, 'blue', 'edge', 34.34, 'strict');
