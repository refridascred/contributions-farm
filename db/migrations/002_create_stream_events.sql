-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (rank, label, region) VALUES (70, 'open', 'blue');
INSERT INTO stream_events (rank, label, region) VALUES (18, 'green', 'staging');
INSERT INTO stream_events (rank, label, region) VALUES (93, 'eu-west', 'primary');
