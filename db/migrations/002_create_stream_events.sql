-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (count, region, weight, state) VALUES (33, 'green', 13.03, 'staging');
INSERT INTO stream_events (count, region, weight, state) VALUES (29, 'green', 70.31, 'fallback');
