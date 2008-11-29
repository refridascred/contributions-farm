-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (label, state, owner, ratio) VALUES ('stable', 'cached', 'strict', 39.05);
INSERT INTO stream_events (label, state, owner, ratio) VALUES ('eu-west', 'green', 'green', 51.95);
