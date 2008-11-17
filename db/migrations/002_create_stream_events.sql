-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (weight, active, label, owner, count) VALUES (65.88, 3, 'cached', 'stable', 45);
INSERT INTO stream_events (weight, active, label, owner, count) VALUES (6.95, 24, 'open', 'eu-west', 77);
