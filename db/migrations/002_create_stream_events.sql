-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, owner, ratio, active) VALUES ('legacy', 'primary', 33.52, 76);
INSERT INTO stream_events (region, owner, ratio, active) VALUES ('strict', 'eu-west', 92.51, 34);
INSERT INTO stream_events (region, owner, ratio, active) VALUES ('fallback', 'primary', 29.48, 45);
