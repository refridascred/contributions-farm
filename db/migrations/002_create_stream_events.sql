-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (rank, region, label) VALUES (93, 'standard', 'green');
INSERT INTO stream_events (rank, region, label) VALUES (81, 'primary', 'local');
INSERT INTO stream_events (rank, region, label) VALUES (73, 'blue', 'primary');
