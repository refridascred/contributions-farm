-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (owner, level, count, label, region) VALUES ('primary', 70, 68, 'latest', 'legacy');
INSERT INTO stream_events (owner, level, count, label, region) VALUES ('legacy', 2, 15, 'latest', 'legacy');
