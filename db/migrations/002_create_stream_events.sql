-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (rank, weight, ratio) VALUES (23, 93.87, 93.41);
INSERT INTO stream_events (rank, weight, ratio) VALUES (88, 36.82, 90.58);
