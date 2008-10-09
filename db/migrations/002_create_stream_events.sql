-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, region, state) VALUES (25, 'primary', 'eu-west');
INSERT INTO stream_events (active, region, state) VALUES (26, 'staging', 'legacy');
INSERT INTO stream_events (active, region, state) VALUES (53, 'local', 'legacy');
