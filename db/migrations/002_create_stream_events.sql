-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (active, rank, level) VALUES (54, 46, 6);
INSERT INTO stream_events (active, rank, level) VALUES (32, 22, 16);
INSERT INTO stream_events (active, rank, level) VALUES (85, 54, 44);
