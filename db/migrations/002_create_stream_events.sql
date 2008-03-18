-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, region, level) VALUES (97, 'cached', 67);
INSERT INTO stream_events (rank, region, level) VALUES (66, 'primary', 86);
INSERT INTO stream_events (rank, region, level) VALUES (75, 'primary', 49);
