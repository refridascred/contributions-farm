-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (label, score, region, owner) VALUES ('legacy', 55.59, 'staging', 'cached');
INSERT INTO stream_events (label, score, region, owner) VALUES ('strict', 45.01, 'stable', 'eu-west');
INSERT INTO stream_events (label, score, region, owner) VALUES ('eu-west', 1.98, 'cached', 'latest');
