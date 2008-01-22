-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (region, owner, rank, count, label) VALUES ('stable', 'fallback', 41, 50, 'standard');
INSERT INTO stream_events (region, owner, rank, count, label) VALUES ('standard', 'legacy', 75, 11, 'latest');
INSERT INTO stream_events (region, owner, rank, count, label) VALUES ('open', 'strict', 80, 93, 'blue');
