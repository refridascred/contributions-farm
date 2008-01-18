-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (ratio, label, owner, active) VALUES (88.84, 'stable', 'legacy', 75);
INSERT INTO stream_events (ratio, label, owner, active) VALUES (59.8, 'blue', 'green', 71);
