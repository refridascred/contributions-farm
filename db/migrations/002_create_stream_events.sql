-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (rank, ratio, owner, active) VALUES (64, 3.94, 'open', 6);
INSERT INTO stream_events (rank, ratio, owner, active) VALUES (2, 29.81, 'strict', 64);
INSERT INTO stream_events (rank, ratio, owner, active) VALUES (5, 15.1, 'eu-west', 27);
