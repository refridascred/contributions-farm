-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, ratio) VALUES ('standard', 64.03);
INSERT INTO stream_events (state, ratio) VALUES ('staging', 16.61);
INSERT INTO stream_events (state, ratio) VALUES ('green', 76.55);
