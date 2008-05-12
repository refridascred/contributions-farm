-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (score, region, label, count) VALUES (67.19, 'strict', 'standard', 84);
INSERT INTO stream_events (score, region, label, count) VALUES (87.58, 'open', 'standard', 82);
INSERT INTO stream_events (score, region, label, count) VALUES (62.55, 'stable', 'staging', 18);
