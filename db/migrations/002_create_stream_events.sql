-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (ratio, active, owner) VALUES (62.91, 23, 'open');
INSERT INTO stream_events (ratio, active, owner) VALUES (55.87, 33, 'blue');
INSERT INTO stream_events (ratio, active, owner) VALUES (13.29, 11, 'cached');
