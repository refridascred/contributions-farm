-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (active, region, rank, level) VALUES (64, 'primary', 86, 71);
INSERT INTO stream_events (active, region, rank, level) VALUES (22, 'green', 36, 5);
INSERT INTO stream_events (active, region, rank, level) VALUES (95, 'cached', 25, 17);
