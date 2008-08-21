-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (owner, weight, active) VALUES ('edge', 68.46, 55);
INSERT INTO stream_events (owner, weight, active) VALUES ('eu-west', 77.54, 56);
