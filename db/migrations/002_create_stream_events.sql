-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, label, count, state) VALUES ('latest', 'blue', 95, 'strict');
INSERT INTO stream_events (token, label, count, state) VALUES ('latest', 'standard', 50, 'fallback');
INSERT INTO stream_events (token, label, count, state) VALUES ('legacy', 'open', 14, 'fallback');
