-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, state, token, active) VALUES ('eu-west', 'latest', 'green', 8);
INSERT INTO stream_events (region, state, token, active) VALUES ('local', 'cached', 'legacy', 68);
INSERT INTO stream_events (region, state, token, active) VALUES ('stable', 'eu-west', 'edge', 60);
