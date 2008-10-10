-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (token, count, level, owner, state) VALUES ('standard', 95, 60, 'fallback', 'eu-west');
INSERT INTO stream_events (token, count, level, owner, state) VALUES ('edge', 38, 34, 'eu-west', 'local');
INSERT INTO stream_events (token, count, level, owner, state) VALUES ('edge', 35, 31, 'primary', 'fallback');
