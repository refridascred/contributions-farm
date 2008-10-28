-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, owner, rank, level, weight) VALUES ('primary', 'green', 14, 56, 7.84);
INSERT INTO stream_events (token, owner, rank, level, weight) VALUES ('blue', 'primary', 41, 46, 93.59);
INSERT INTO stream_events (token, owner, rank, level, weight) VALUES ('edge', 'edge', 2, 67, 53.94);
