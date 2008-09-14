-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (label, token, state, ratio) VALUES ('blue', 'staging', 'green', 86.79);
INSERT INTO stream_events (label, token, state, ratio) VALUES ('staging', 'legacy', 'latest', 66.42);
