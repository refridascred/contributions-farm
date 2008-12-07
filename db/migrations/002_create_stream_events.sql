-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (owner, level, rank) VALUES ('stable', 11, 76);
INSERT INTO stream_events (owner, level, rank) VALUES ('green', 59, 4);
INSERT INTO stream_events (owner, level, rank) VALUES ('stable', 41, 6);
