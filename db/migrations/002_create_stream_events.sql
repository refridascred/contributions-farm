-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (level, active, weight, rank, owner) VALUES (21, 20, 46.45, 52, 'edge');
INSERT INTO stream_events (level, active, weight, rank, owner) VALUES (15, 22, 31.72, 70, 'latest');
INSERT INTO stream_events (level, active, weight, rank, owner) VALUES (37, 83, 19.63, 13, 'legacy');
