-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (region, weight, owner, count, active) VALUES ('green', 26.76, 'edge', 70, 32);
INSERT INTO stream_events (region, weight, owner, count, active) VALUES ('open', 4.99, 'cached', 54, 88);
