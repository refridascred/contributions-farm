-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, active, rank, owner) VALUES ('local', 7, 19, 'edge');
INSERT INTO stream_events (token, active, rank, owner) VALUES ('eu-west', 40, 88, 'cached');
INSERT INTO stream_events (token, active, rank, owner) VALUES ('stable', 43, 41, 'legacy');
