-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    label TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, token, label, ratio, score) VALUES ('stable', 'legacy', 'green', 1.16, 35.69);
INSERT INTO stream_events (owner, token, label, ratio, score) VALUES ('open', 'legacy', 'eu-west', 31.61, 23.35);
INSERT INTO stream_events (owner, token, label, ratio, score) VALUES ('eu-west', 'standard', 'local', 71.7, 19.83);
