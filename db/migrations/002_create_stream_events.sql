-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (rank, owner, level) VALUES (10, 'primary', 57);
INSERT INTO stream_events (rank, owner, level) VALUES (38, 'stable', 17);
INSERT INTO stream_events (rank, owner, level) VALUES (77, 'local', 1);
