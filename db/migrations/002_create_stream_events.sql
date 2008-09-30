-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (rank, level) VALUES (24, 75);
INSERT INTO stream_events (rank, level) VALUES (2, 30);
INSERT INTO stream_events (rank, level) VALUES (72, 52);
