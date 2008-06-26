-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (score, rank, owner, region) VALUES (34.77, 41, 'cached', 'blue');
INSERT INTO stream_events (score, rank, owner, region) VALUES (40.67, 5, 'fallback', 'standard');
INSERT INTO stream_events (score, rank, owner, region) VALUES (15.07, 68, 'eu-west', 'local');
