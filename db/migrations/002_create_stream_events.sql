-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (ratio, region, count, score, label) VALUES (27.33, 'staging', 55, 84.92, 'stable');
INSERT INTO stream_events (ratio, region, count, score, label) VALUES (75.24, 'green', 38, 2.08, 'primary');
