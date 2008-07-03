-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    level INTEGER,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, rank, level, ratio) VALUES (30, 92, 12, 46.38);
INSERT INTO stream_events (active, rank, level, ratio) VALUES (53, 71, 62, 33.42);
INSERT INTO stream_events (active, rank, level, ratio) VALUES (85, 42, 59, 68.02);
