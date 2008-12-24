-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    level INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (active, rank, level, region, score) VALUES (37, 19, 75, 'staging', 24.32);
INSERT INTO stream_events (active, rank, level, region, score) VALUES (69, 98, 93, 'local', 56.03);
INSERT INTO stream_events (active, rank, level, region, score) VALUES (89, 89, 98, 'strict', 32.32);
