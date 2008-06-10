-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, owner, ratio, rank) VALUES (56, 'primary', 97.83, 28);
INSERT INTO stream_events (count, owner, ratio, rank) VALUES (80, 'staging', 71.71, 66);
INSERT INTO stream_events (count, owner, ratio, rank) VALUES (96, 'latest', 0.5, 6);
