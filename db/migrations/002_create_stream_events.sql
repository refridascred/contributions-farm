-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (ratio, active, label, owner) VALUES (86.67, 44, 'staging', 'fallback');
INSERT INTO stream_events (ratio, active, label, owner) VALUES (26.1, 97, 'latest', 'primary');
INSERT INTO stream_events (ratio, active, label, owner) VALUES (60.08, 77, 'green', 'latest');
