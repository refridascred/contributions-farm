-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, owner, score) VALUES (48, 'latest', 39.45);
INSERT INTO stream_events (active, owner, score) VALUES (27, 'fallback', 65.87);
INSERT INTO stream_events (active, owner, score) VALUES (40, 'cached', 53.37);
