-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (region, active, owner) VALUES ('green', 83, 'standard');
INSERT INTO stream_events (region, active, owner) VALUES ('open', 38, 'staging');
INSERT INTO stream_events (region, active, owner) VALUES ('standard', 99, 'local');
