-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (region, rank, label) VALUES ('local', 0, 'latest');
INSERT INTO stream_events (region, rank, label) VALUES ('cached', 7, 'staging');
