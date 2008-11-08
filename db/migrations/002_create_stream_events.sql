-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (ratio, active, score, region, label) VALUES (53.43, 0, 15.47, 'staging', 'latest');
INSERT INTO stream_events (ratio, active, score, region, label) VALUES (35.0, 46, 31.85, 'cached', 'latest');
INSERT INTO stream_events (ratio, active, score, region, label) VALUES (1.43, 41, 88.18, 'stable', 'eu-west');
