-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (region, level, state) VALUES ('primary', 54, 'latest');
INSERT INTO stream_events (region, level, state) VALUES ('edge', 52, 'edge');
INSERT INTO stream_events (region, level, state) VALUES ('cached', 88, 'legacy');
