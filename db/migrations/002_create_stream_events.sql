-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (label, rank, region) VALUES ('staging', 87, 'strict');
INSERT INTO stream_events (label, rank, region) VALUES ('legacy', 7, 'primary');
INSERT INTO stream_events (label, rank, region) VALUES ('cached', 93, 'open');
