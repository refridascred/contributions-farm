-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, region, score) VALUES ('legacy', 'primary', 29.61);
INSERT INTO stream_events (label, region, score) VALUES ('staging', 'green', 42.02);
INSERT INTO stream_events (label, region, score) VALUES ('latest', 'strict', 55.42);
