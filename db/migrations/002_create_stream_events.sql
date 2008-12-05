-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (rank, ratio, level) VALUES (36, 43.64, 16);
INSERT INTO stream_events (rank, ratio, level) VALUES (76, 75.22, 38);
INSERT INTO stream_events (rank, ratio, level) VALUES (80, 59.01, 90);
