-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (ratio, rank, count, owner, token) VALUES (55.04, 66, 85, 'open', 'primary');
INSERT INTO stream_events (ratio, rank, count, owner, token) VALUES (77.17, 11, 13, 'standard', 'cached');
