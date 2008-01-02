-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (token, rank, level, active) VALUES ('staging', 12, 74, 18);
INSERT INTO stream_events (token, rank, level, active) VALUES ('eu-west', 41, 68, 3);
