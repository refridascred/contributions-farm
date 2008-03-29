-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, rank, ratio) VALUES ('blue', 95, 10.07);
INSERT INTO stream_events (label, rank, ratio) VALUES ('edge', 61, 53.01);
INSERT INTO stream_events (label, rank, ratio) VALUES ('fallback', 2, 38.14);
