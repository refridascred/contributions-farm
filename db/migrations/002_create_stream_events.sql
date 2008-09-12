-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (rank, ratio, level, label) VALUES (40, 78.11, 57, 'local');
INSERT INTO stream_events (rank, ratio, level, label) VALUES (37, 8.13, 87, 'fallback');
INSERT INTO stream_events (rank, ratio, level, label) VALUES (39, 2.69, 19, 'edge');
