-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (weight, score, owner, region) VALUES (37.45, 86.76, 'blue', 'strict');
INSERT INTO stream_events (weight, score, owner, region) VALUES (1.26, 67.51, 'staging', 'primary');
