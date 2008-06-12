-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, weight, label) VALUES ('standard', 96.96, 'strict');
INSERT INTO stream_events (state, weight, label) VALUES ('open', 76.63, 'latest');
