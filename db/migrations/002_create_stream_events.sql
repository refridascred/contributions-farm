-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (rank, ratio, region) VALUES (93, 40.94, 'fallback');
INSERT INTO stream_events (rank, ratio, region) VALUES (71, 78.25, 'green');
INSERT INTO stream_events (rank, ratio, region) VALUES (36, 54.15, 'strict');
