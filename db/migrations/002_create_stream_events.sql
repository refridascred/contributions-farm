-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, rank, region, label) VALUES (78.92, 26, 'primary', 'eu-west');
INSERT INTO stream_events (ratio, rank, region, label) VALUES (60.74, 76, 'stable', 'blue');
INSERT INTO stream_events (ratio, rank, region, label) VALUES (77.05, 75, 'strict', 'standard');
