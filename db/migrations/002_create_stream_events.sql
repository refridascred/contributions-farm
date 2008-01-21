-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, owner, ratio, region) VALUES (39, 'strict', 82.28, 'standard');
INSERT INTO stream_events (active, owner, ratio, region) VALUES (38, 'fallback', 52.19, 'green');
INSERT INTO stream_events (active, owner, ratio, region) VALUES (32, 'legacy', 90.56, 'legacy');
