-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (rank, weight, region) VALUES (96, 25.66, 'latest');
INSERT INTO stream_events (rank, weight, region) VALUES (37, 79.44, 'eu-west');
INSERT INTO stream_events (rank, weight, region) VALUES (71, 96.1, 'open');
