-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (label, count, score, region) VALUES ('edge', 5, 16.88, 'eu-west');
INSERT INTO stream_events (label, count, score, region) VALUES ('strict', 24, 76.43, 'standard');
INSERT INTO stream_events (label, count, score, region) VALUES ('cached', 20, 17.15, 'staging');
