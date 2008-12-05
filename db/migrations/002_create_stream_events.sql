-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    label TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (region, owner, label, weight, score) VALUES ('strict', 'stable', 'staging', 86.45, 15.09);
INSERT INTO stream_events (region, owner, label, weight, score) VALUES ('blue', 'green', 'open', 85.24, 52.41);
