-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (rank, token, score, label) VALUES (39, 'standard', 54.34, 'open');
INSERT INTO stream_events (rank, token, score, label) VALUES (49, 'fallback', 90.65, 'open');
INSERT INTO stream_events (rank, token, score, label) VALUES (0, 'eu-west', 33.06, 'edge');
