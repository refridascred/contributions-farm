-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (label, state, ratio) VALUES ('eu-west', 'stable', 19.55);
INSERT INTO stream_events (label, state, ratio) VALUES ('legacy', 'standard', 55.82);
INSERT INTO stream_events (label, state, ratio) VALUES ('stable', 'latest', 61.2);
