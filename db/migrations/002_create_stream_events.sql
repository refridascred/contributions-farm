-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (owner, score, token, label) VALUES ('standard', 49.49, 'blue', 'open');
INSERT INTO stream_events (owner, score, token, label) VALUES ('stable', 14.26, 'legacy', 'open');
INSERT INTO stream_events (owner, score, token, label) VALUES ('primary', 74.23, 'blue', 'cached');
