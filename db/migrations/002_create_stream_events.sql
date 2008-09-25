-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (ratio, rank, level) VALUES (87.45, 44, 57);
INSERT INTO stream_events (ratio, rank, level) VALUES (94.75, 78, 22);
INSERT INTO stream_events (ratio, rank, level) VALUES (10.23, 13, 79);
