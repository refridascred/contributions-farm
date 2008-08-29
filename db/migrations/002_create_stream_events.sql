-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    rank INTEGER,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (token, label, rank, level) VALUES ('primary', 'fallback', 97, 96);
INSERT INTO stream_events (token, label, rank, level) VALUES ('standard', 'edge', 36, 75);
INSERT INTO stream_events (token, label, rank, level) VALUES ('latest', 'fallback', 11, 19);
