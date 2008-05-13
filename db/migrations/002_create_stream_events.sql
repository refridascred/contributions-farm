-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, region, owner) VALUES (87, 'open', 'standard');
INSERT INTO stream_events (active, region, owner) VALUES (43, 'blue', 'stable');
INSERT INTO stream_events (active, region, owner) VALUES (56, 'blue', 'standard');
