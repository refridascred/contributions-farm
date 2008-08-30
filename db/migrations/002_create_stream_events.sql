-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    token TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (label, weight, token, rank, active) VALUES ('fallback', 43.3, 'green', 2, 2);
INSERT INTO stream_events (label, weight, token, rank, active) VALUES ('eu-west', 89.61, 'latest', 21, 4);
