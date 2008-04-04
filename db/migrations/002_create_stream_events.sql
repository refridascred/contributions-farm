-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    rank INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (token, weight, rank, owner) VALUES ('green', 17.85, 64, 'cached');
INSERT INTO stream_events (token, weight, rank, owner) VALUES ('stable', 60.73, 76, 'stable');
INSERT INTO stream_events (token, weight, rank, owner) VALUES ('local', 80.21, 95, 'local');
