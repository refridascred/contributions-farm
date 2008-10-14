-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (owner, token, score, region, rank) VALUES ('cached', 'standard', 4.97, 'primary', 84);
INSERT INTO stream_events (owner, token, score, region, rank) VALUES ('stable', 'stable', 1.45, 'green', 32);
