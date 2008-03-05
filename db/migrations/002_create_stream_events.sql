-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    rank INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (token, level, rank, region, active) VALUES ('eu-west', 91, 91, 'blue', 81);
INSERT INTO stream_events (token, level, rank, region, active) VALUES ('edge', 37, 44, 'green', 79);
