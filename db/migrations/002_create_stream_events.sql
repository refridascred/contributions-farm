-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (state, count, active, token) VALUES ('open', 58, 56, 'staging');
INSERT INTO stream_events (state, count, active, token) VALUES ('local', 71, 64, 'latest');
INSERT INTO stream_events (state, count, active, token) VALUES ('green', 77, 62, 'green');
