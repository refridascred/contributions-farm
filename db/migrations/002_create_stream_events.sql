-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (owner, score, label) VALUES ('stable', 9.94, 'eu-west');
INSERT INTO stream_events (owner, score, label) VALUES ('latest', 31.04, 'local');
INSERT INTO stream_events (owner, score, label) VALUES ('local', 2.27, 'cached');
