-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (score, active, region, owner, label) VALUES (30.77, 19, 'local', 'latest', 'latest');
INSERT INTO stream_events (score, active, region, owner, label) VALUES (20.91, 90, 'green', 'edge', 'latest');
