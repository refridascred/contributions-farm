-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    token TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (state, token, region, ratio) VALUES ('standard', 'fallback', 'standard', 96.35);
INSERT INTO stream_events (state, token, region, ratio) VALUES ('cached', 'standard', 'open', 52.8);
INSERT INTO stream_events (state, token, region, ratio) VALUES ('local', 'stable', 'edge', 25.89);
