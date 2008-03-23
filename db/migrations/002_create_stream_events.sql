-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    rank INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (level, token, rank, label, score) VALUES (21, 'local', 6, 'standard', 96.26);
INSERT INTO stream_events (level, token, rank, label, score) VALUES (11, 'primary', 60, 'edge', 51.26);
INSERT INTO stream_events (level, token, rank, label, score) VALUES (44, 'legacy', 97, 'staging', 65.73);
