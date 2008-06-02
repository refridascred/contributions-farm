-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, rank, weight) VALUES (96.61, 93, 43.39);
INSERT INTO stream_events (ratio, rank, weight) VALUES (86.43, 8, 96.43);
INSERT INTO stream_events (ratio, rank, weight) VALUES (34.81, 42, 21.71);
