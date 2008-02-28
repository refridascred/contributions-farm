-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (level, rank, count, active) VALUES (76, 7, 17, 44);
INSERT INTO stream_events (level, rank, count, active) VALUES (11, 10, 83, 11);
INSERT INTO stream_events (level, rank, count, active) VALUES (96, 36, 74, 88);
