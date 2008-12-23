-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, owner, region, count, weight) VALUES (25, 'green', 'local', 31, 16.93);
INSERT INTO stream_events (active, owner, region, count, weight) VALUES (15, 'primary', 'eu-west', 10, 91.07);
