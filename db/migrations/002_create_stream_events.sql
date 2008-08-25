-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, rank, owner) VALUES ('green', 27, 'green');
INSERT INTO stream_events (token, rank, owner) VALUES ('latest', 37, 'edge');
INSERT INTO stream_events (token, rank, owner) VALUES ('stable', 28, 'fallback');
