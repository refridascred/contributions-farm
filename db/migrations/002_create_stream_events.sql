-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, token, ratio, count) VALUES ('primary', 'open', 15.19, 15);
INSERT INTO stream_events (state, token, ratio, count) VALUES ('staging', 'local', 87.27, 42);
INSERT INTO stream_events (state, token, ratio, count) VALUES ('edge', 'green', 65.48, 55);
