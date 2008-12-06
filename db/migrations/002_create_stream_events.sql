-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, active, count) VALUES ('staging', 56, 18);
INSERT INTO stream_events (state, active, count) VALUES ('fallback', 67, 72);
INSERT INTO stream_events (state, active, count) VALUES ('latest', 88, 26);
