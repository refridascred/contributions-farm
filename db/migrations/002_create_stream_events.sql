-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    owner TEXT NOT NULL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (rank, level, owner, region, token) VALUES (1, 39, 'local', 'primary', 'stable');
INSERT INTO stream_events (rank, level, owner, region, token) VALUES (78, 73, 'standard', 'stable', 'stable');
