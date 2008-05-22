-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    label TEXT,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (owner, label, rank, region) VALUES ('staging', 'latest', 88, 'blue');
INSERT INTO stream_events (owner, label, rank, region) VALUES ('legacy', 'standard', 66, 'open');
