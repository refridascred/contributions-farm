-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (rank, active, region, level, owner) VALUES (58, 89, 'green', 11, 'green');
INSERT INTO stream_events (rank, active, region, level, owner) VALUES (97, 8, 'cached', 70, 'edge');
