-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (owner, token, ratio) VALUES ('stable', 'blue', 33.66);
INSERT INTO stream_events (owner, token, ratio) VALUES ('standard', 'green', 88.97);
INSERT INTO stream_events (owner, token, ratio) VALUES ('edge', 'cached', 7.57);
