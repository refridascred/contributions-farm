-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, rank, region, state) VALUES (93, 10, 'eu-west', 'edge');
INSERT INTO stream_events (active, rank, region, state) VALUES (62, 42, 'standard', 'primary');
INSERT INTO stream_events (active, rank, region, state) VALUES (42, 51, 'fallback', 'latest');
