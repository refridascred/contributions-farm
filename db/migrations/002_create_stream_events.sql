-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (rank, level, label) VALUES (42, 34, 'staging');
INSERT INTO stream_events (rank, level, label) VALUES (2, 81, 'blue');
INSERT INTO stream_events (rank, level, label) VALUES (33, 73, 'legacy');
