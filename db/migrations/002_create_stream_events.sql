-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (label, rank, weight, level) VALUES ('latest', 64, 74.74, 28);
INSERT INTO stream_events (label, rank, weight, level) VALUES ('stable', 26, 12.42, 22);
INSERT INTO stream_events (label, rank, weight, level) VALUES ('blue', 93, 54.71, 31);
