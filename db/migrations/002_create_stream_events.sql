-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (count, ratio, region, state) VALUES (80, 10.78, 'latest', 'local');
INSERT INTO stream_events (count, ratio, region, state) VALUES (79, 80.62, 'primary', 'edge');
