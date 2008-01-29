-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, ratio) VALUES ('standard', 22.04);
INSERT INTO stream_events (state, ratio) VALUES ('edge', 70.64);
INSERT INTO stream_events (state, ratio) VALUES ('edge', 66.44);
