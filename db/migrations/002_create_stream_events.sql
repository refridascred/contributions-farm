-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (level, owner, active, score) VALUES (24, 'strict', 51, 5.77);
INSERT INTO stream_events (level, owner, active, score) VALUES (20, 'cached', 88, 84.07);
INSERT INTO stream_events (level, owner, active, score) VALUES (79, 'staging', 48, 49.89);
