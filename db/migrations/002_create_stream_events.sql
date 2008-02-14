-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (token, region, active, count, rank) VALUES ('eu-west', 'local', 31, 40, 29);
INSERT INTO stream_events (token, region, active, count, rank) VALUES ('staging', 'local', 0, 35, 70);
