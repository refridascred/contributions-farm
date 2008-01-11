-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (rank, level) VALUES (39, 94);
INSERT INTO stream_events (rank, level) VALUES (72, 56);
INSERT INTO stream_events (rank, level) VALUES (86, 61);
