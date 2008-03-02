-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (score, rank, owner, label) VALUES (95.8, 30, 'primary', 'stable');
INSERT INTO stream_events (score, rank, owner, label) VALUES (49.0, 75, 'primary', 'eu-west');
