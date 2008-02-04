-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (active, level, owner) VALUES (94, 86, 'edge');
INSERT INTO stream_events (active, level, owner) VALUES (5, 46, 'latest');
INSERT INTO stream_events (active, level, owner) VALUES (55, 20, 'open');
