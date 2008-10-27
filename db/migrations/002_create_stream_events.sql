-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (label, region, score, ratio) VALUES ('staging', 'local', 2.57, 30.16);
INSERT INTO stream_events (label, region, score, ratio) VALUES ('open', 'local', 1.98, 51.66);
