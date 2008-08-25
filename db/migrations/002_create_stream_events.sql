-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (label, state, ratio) VALUES ('strict', 'latest', 67.15);
INSERT INTO stream_events (label, state, ratio) VALUES ('edge', 'staging', 85.71);
