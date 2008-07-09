-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (ratio, weight, state) VALUES (8.95, 4.34, 'strict');
INSERT INTO stream_events (ratio, weight, state) VALUES (60.36, 20.33, 'strict');
