-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, rank, score, ratio) VALUES ('primary', 41, 21.04, 66.04);
INSERT INTO stream_events (label, rank, score, ratio) VALUES ('staging', 44, 20.7, 1.37);
