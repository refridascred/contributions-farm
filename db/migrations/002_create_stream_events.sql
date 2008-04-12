-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, score) VALUES ('green', 22.72);
INSERT INTO stream_events (label, score) VALUES ('staging', 91.0);
INSERT INTO stream_events (label, score) VALUES ('local', 18.47);
