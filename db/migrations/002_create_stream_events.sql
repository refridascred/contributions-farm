-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (region, level, count, rank, label) VALUES ('stable', 35, 95, 91, 'blue');
INSERT INTO stream_events (region, level, count, rank, label) VALUES ('primary', 12, 60, 7, 'eu-west');
INSERT INTO stream_events (region, level, count, rank, label) VALUES ('eu-west', 18, 86, 68, 'local');
