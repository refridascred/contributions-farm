-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (rank, ratio, level) VALUES (9, 32.44, 52);
INSERT INTO stream_events (rank, ratio, level) VALUES (40, 84.98, 85);
INSERT INTO stream_events (rank, ratio, level) VALUES (45, 67.09, 48);
