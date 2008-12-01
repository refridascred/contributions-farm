-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (score, rank, owner, weight, region) VALUES (16.69, 1, 'open', 2.68, 'standard');
INSERT INTO stream_events (score, rank, owner, weight, region) VALUES (71.48, 2, 'cached', 85.18, 'strict');
