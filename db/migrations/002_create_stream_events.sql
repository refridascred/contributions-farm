-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (state, rank, score, owner, label) VALUES ('local', 7, 52.4, 'legacy', 'primary');
INSERT INTO stream_events (state, rank, score, owner, label) VALUES ('fallback', 57, 51.93, 'latest', 'stable');
INSERT INTO stream_events (state, rank, score, owner, label) VALUES ('open', 42, 92.0, 'open', 'local');
