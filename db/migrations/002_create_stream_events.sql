-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (active, owner, score) VALUES (5, 'legacy', 77.14);
INSERT INTO stream_events (active, owner, score) VALUES (73, 'stable', 80.08);
INSERT INTO stream_events (active, owner, score) VALUES (76, 'green', 95.56);
