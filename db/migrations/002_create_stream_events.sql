-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, weight, ratio) VALUES (86, 75.68, 80.16);
INSERT INTO stream_events (active, weight, ratio) VALUES (16, 41.54, 4.1);
INSERT INTO stream_events (active, weight, ratio) VALUES (95, 21.03, 22.64);
