-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (weight, ratio, state) VALUES (35.13, 40.28, 'edge');
INSERT INTO stream_events (weight, ratio, state) VALUES (81.37, 67.82, 'blue');
