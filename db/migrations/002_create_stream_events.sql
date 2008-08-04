-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    rank INTEGER,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, token, rank, ratio) VALUES (53, 'primary', 81, 73.56);
INSERT INTO stream_events (level, token, rank, ratio) VALUES (36, 'stable', 37, 5.44);
