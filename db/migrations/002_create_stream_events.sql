-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (region, active, state) VALUES ('blue', 54, 'latest');
INSERT INTO stream_events (region, active, state) VALUES ('local', 20, 'local');
INSERT INTO stream_events (region, active, state) VALUES ('staging', 50, 'eu-west');
