-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (ratio, state, region, weight) VALUES (74.93, 'open', 'stable', 57.49);
INSERT INTO stream_events (ratio, state, region, weight) VALUES (62.21, 'open', 'latest', 63.67);
