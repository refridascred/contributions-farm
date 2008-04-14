-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (score, owner, label) VALUES (54.65, 'stable', 'cached');
INSERT INTO stream_events (score, owner, label) VALUES (91.59, 'stable', 'staging');
INSERT INTO stream_events (score, owner, label) VALUES (5.28, 'legacy', 'edge');
