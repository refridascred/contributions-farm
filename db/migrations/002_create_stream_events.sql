-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, rank, count, owner, region) VALUES ('latest', 19, 23, 'primary', 'latest');
INSERT INTO stream_events (token, rank, count, owner, region) VALUES ('edge', 31, 67, 'stable', 'stable');
INSERT INTO stream_events (token, rank, count, owner, region) VALUES ('open', 7, 29, 'primary', 'primary');
