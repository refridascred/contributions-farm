-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, ratio, rank) VALUES (96, 28.83, 40);
INSERT INTO stream_events (count, ratio, rank) VALUES (17, 49.8, 94);
INSERT INTO stream_events (count, ratio, rank) VALUES (44, 81.18, 72);
