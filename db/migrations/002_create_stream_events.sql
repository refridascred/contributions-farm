-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, label, ratio, rank) VALUES (95, 'open', 35.21, 14);
INSERT INTO stream_events (level, label, ratio, rank) VALUES (77, 'strict', 71.0, 85);
INSERT INTO stream_events (level, label, ratio, rank) VALUES (11, 'eu-west', 62.45, 30);
