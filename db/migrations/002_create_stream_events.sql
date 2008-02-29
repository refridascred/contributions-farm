-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, token, state) VALUES ('edge', 'blue', 'fallback');
INSERT INTO stream_events (region, token, state) VALUES ('strict', 'blue', 'edge');
