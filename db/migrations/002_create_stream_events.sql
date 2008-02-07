-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (active, rank, ratio, label) VALUES (43, 43, 71.27, 'blue');
INSERT INTO stream_events (active, rank, ratio, label) VALUES (73, 22, 29.48, 'standard');
