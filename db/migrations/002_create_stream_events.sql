-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (region, label, active, state) VALUES ('edge', 'standard', 94, 'latest');
INSERT INTO stream_events (region, label, active, state) VALUES ('staging', 'latest', 40, 'eu-west');
