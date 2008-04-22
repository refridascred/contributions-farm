-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, token, rank) VALUES (96.72, 'fallback', 63);
INSERT INTO stream_events (ratio, token, rank) VALUES (59.66, 'legacy', 79);
INSERT INTO stream_events (ratio, token, rank) VALUES (68.66, 'local', 46);
