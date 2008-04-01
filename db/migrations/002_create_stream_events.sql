-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (owner, level, score) VALUES ('staging', 71, 7.34);
INSERT INTO stream_events (owner, level, score) VALUES ('latest', 15, 63.99);
INSERT INTO stream_events (owner, level, score) VALUES ('blue', 91, 24.88);
