-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (owner, active, score, ratio) VALUES ('green', 12, 75.92, 29.53);
INSERT INTO stream_events (owner, active, score, ratio) VALUES ('eu-west', 20, 1.9, 1.42);
INSERT INTO stream_events (owner, active, score, ratio) VALUES ('stable', 4, 53.73, 4.43);
