-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, label, score) VALUES ('staging', 'green', 18.87);
INSERT INTO stream_events (region, label, score) VALUES ('latest', 'green', 58.04);
INSERT INTO stream_events (region, label, score) VALUES ('standard', 'cached', 56.83);
