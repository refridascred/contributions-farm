-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, rank, label) VALUES (33.43, 98, 'standard');
INSERT INTO stream_events (ratio, rank, label) VALUES (52.57, 83, 'legacy');
INSERT INTO stream_events (ratio, rank, label) VALUES (68.3, 55, 'primary');
