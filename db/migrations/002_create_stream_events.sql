-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (state, level, active, token) VALUES ('open', 92, 17, 'primary');
INSERT INTO stream_events (state, level, active, token) VALUES ('edge', 85, 81, 'primary');
INSERT INTO stream_events (state, level, active, token) VALUES ('green', 6, 90, 'standard');
