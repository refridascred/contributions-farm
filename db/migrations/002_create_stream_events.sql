-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (active, level, owner, rank) VALUES (43, 96, 'primary', 35);
INSERT INTO stream_events (active, level, owner, rank) VALUES (81, 19, 'standard', 10);
INSERT INTO stream_events (active, level, owner, rank) VALUES (53, 0, 'fallback', 20);
