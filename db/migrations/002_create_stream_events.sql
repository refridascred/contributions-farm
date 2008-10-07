-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, rank, token, weight) VALUES (98, 7, 'standard', 14.05);
INSERT INTO stream_events (count, rank, token, weight) VALUES (62, 32, 'primary', 87.82);
INSERT INTO stream_events (count, rank, token, weight) VALUES (96, 71, 'local', 19.55);
