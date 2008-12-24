-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (region, score, owner, weight, label) VALUES ('edge', 33.16, 'local', 97.04, 'legacy');
INSERT INTO stream_events (region, score, owner, weight, label) VALUES ('blue', 11.75, 'local', 47.27, 'open');
