-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (owner, active, rank, weight) VALUES ('open', 59, 25, 30.7);
INSERT INTO stream_events (owner, active, rank, weight) VALUES ('local', 55, 91, 89.61);
