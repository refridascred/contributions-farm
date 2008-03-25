-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (token, ratio) VALUES ('edge', 32.66);
INSERT INTO stream_events (token, ratio) VALUES ('legacy', 6.56);
INSERT INTO stream_events (token, ratio) VALUES ('stable', 19.76);
