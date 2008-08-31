-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, score, active) VALUES ('primary', 43.52, 54);
INSERT INTO stream_events (label, score, active) VALUES ('legacy', 43.24, 15);
INSERT INTO stream_events (label, score, active) VALUES ('strict', 41.92, 77);
