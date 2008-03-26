-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, ratio, owner, token) VALUES ('open', 7.31, 'stable', 'stable');
INSERT INTO stream_events (label, ratio, owner, token) VALUES ('eu-west', 11.97, 'legacy', 'local');
