-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, owner, rank) VALUES ('latest', 'open', 17);
INSERT INTO stream_events (region, owner, rank) VALUES ('eu-west', 'cached', 87);
INSERT INTO stream_events (region, owner, rank) VALUES ('local', 'open', 59);
