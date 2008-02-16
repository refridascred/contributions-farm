-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (weight, region, owner, active) VALUES (80.62, 'strict', 'strict', 6);
INSERT INTO stream_events (weight, region, owner, active) VALUES (65.67, 'fallback', 'fallback', 97);
INSERT INTO stream_events (weight, region, owner, active) VALUES (78.75, 'staging', 'strict', 35);
