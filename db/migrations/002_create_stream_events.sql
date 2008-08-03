-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, rank, ratio) VALUES ('blue', 77, 73.54);
INSERT INTO stream_events (region, rank, ratio) VALUES ('blue', 68, 20.44);
