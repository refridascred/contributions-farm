-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, score, rank) VALUES ('staging', 78.71, 64);
INSERT INTO stream_events (region, score, rank) VALUES ('cached', 81.82, 54);
INSERT INTO stream_events (region, score, rank) VALUES ('local', 98.69, 60);
