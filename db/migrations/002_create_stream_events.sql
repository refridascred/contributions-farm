-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (level, rank, label) VALUES (78, 19, 'standard');
INSERT INTO stream_events (level, rank, label) VALUES (53, 42, 'cached');
INSERT INTO stream_events (level, rank, label) VALUES (31, 44, 'latest');
