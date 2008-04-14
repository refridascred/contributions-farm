-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (label, rank, ratio, owner, token) VALUES ('strict', 52, 4.31, 'green', 'blue');
INSERT INTO stream_events (label, rank, ratio, owner, token) VALUES ('local', 43, 2.38, 'strict', 'legacy');
INSERT INTO stream_events (label, rank, ratio, owner, token) VALUES ('open', 42, 90.74, 'legacy', 'staging');
