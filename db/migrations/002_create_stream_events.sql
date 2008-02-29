-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, rank, region, count) VALUES (39, 52, 'eu-west', 90);
INSERT INTO stream_events (level, rank, region, count) VALUES (60, 56, 'open', 41);
INSERT INTO stream_events (level, rank, region, count) VALUES (30, 80, 'cached', 87);
