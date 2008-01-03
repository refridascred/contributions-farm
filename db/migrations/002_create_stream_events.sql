-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (token, region, rank) VALUES ('strict', 'local', 15);
INSERT INTO stream_events (token, region, rank) VALUES ('latest', 'primary', 88);
INSERT INTO stream_events (token, region, rank) VALUES ('legacy', 'standard', 5);
