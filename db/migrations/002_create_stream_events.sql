-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (rank, active, count, ratio, region) VALUES (72, 18, 2, 95.77, 'standard');
INSERT INTO stream_events (rank, active, count, ratio, region) VALUES (95, 19, 76, 46.85, 'standard');
INSERT INTO stream_events (rank, active, count, ratio, region) VALUES (63, 45, 7, 38.91, 'open');
