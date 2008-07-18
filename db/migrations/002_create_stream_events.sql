-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (weight, owner, active, ratio) VALUES (81.0, 'blue', 19, 74.4);
INSERT INTO stream_events (weight, owner, active, ratio) VALUES (43.36, 'blue', 56, 12.31);
INSERT INTO stream_events (weight, owner, active, ratio) VALUES (18.9, 'stable', 24, 51.76);
