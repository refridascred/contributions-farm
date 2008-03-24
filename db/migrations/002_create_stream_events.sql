-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, level, score) VALUES ('eu-west', 61, 80.92);
INSERT INTO stream_events (label, level, score) VALUES ('blue', 88, 18.28);
INSERT INTO stream_events (label, level, score) VALUES ('standard', 14, 53.06);
