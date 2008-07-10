-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    weight REAL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (level, weight, rank, label) VALUES (20, 8.35, 71, 'fallback');
INSERT INTO stream_events (level, weight, rank, label) VALUES (38, 17.36, 29, 'local');
