-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (token, active, state) VALUES ('local', 87, 'legacy');
INSERT INTO stream_events (token, active, state) VALUES ('edge', 99, 'standard');
INSERT INTO stream_events (token, active, state) VALUES ('blue', 52, 'open');
