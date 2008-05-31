-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (rank, count, label, ratio) VALUES (34, 13, 'primary', 73.48);
INSERT INTO stream_events (rank, count, label, ratio) VALUES (61, 59, 'local', 32.61);
INSERT INTO stream_events (rank, count, label, ratio) VALUES (73, 80, 'primary', 76.3);
