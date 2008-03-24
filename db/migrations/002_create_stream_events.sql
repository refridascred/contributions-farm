-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (label, rank, region, state, active) VALUES ('blue', 9, 'edge', 'staging', 68);
INSERT INTO stream_events (label, rank, region, state, active) VALUES ('blue', 97, 'blue', 'latest', 31);
INSERT INTO stream_events (label, rank, region, state, active) VALUES ('fallback', 93, 'latest', 'green', 77);
