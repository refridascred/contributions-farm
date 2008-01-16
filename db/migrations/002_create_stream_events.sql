-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, ratio, weight) VALUES ('blue', 82.51, 85.32);
INSERT INTO stream_events (state, ratio, weight) VALUES ('fallback', 58.64, 88.95);
