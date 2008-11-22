-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, rank, token, label) VALUES (76.86, 49, 'blue', 'cached');
INSERT INTO stream_events (ratio, rank, token, label) VALUES (23.34, 50, 'cached', 'blue');
INSERT INTO stream_events (ratio, rank, token, label) VALUES (53.47, 14, 'cached', 'green');
