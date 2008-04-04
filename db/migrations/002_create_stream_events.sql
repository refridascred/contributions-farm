-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (count, active, ratio, token, state) VALUES (63, 84, 66.67, 'eu-west', 'staging');
INSERT INTO stream_events (count, active, ratio, token, state) VALUES (7, 35, 35.61, 'edge', 'stable');
