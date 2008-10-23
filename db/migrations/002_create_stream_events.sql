-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (token, score, region, rank) VALUES ('legacy', 73.43, 'latest', 76);
INSERT INTO stream_events (token, score, region, rank) VALUES ('legacy', 54.18, 'blue', 53);
INSERT INTO stream_events (token, score, region, rank) VALUES ('open', 35.06, 'local', 69);
