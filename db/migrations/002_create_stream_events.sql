-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (label, score, region, weight) VALUES ('latest', 51.26, 'legacy', 84.39);
INSERT INTO stream_events (label, score, region, weight) VALUES ('legacy', 67.23, 'open', 12.17);
