-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (owner, score, rank, token) VALUES ('standard', 0.47, 41, 'cached');
INSERT INTO stream_events (owner, score, rank, token) VALUES ('local', 4.26, 33, 'primary');
INSERT INTO stream_events (owner, score, rank, token) VALUES ('strict', 85.71, 69, 'stable');
