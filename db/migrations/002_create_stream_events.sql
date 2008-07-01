-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (region, owner, rank) VALUES ('cached', 'open', 35);
INSERT INTO stream_events (region, owner, rank) VALUES ('legacy', 'latest', 17);
INSERT INTO stream_events (region, owner, rank) VALUES ('latest', 'edge', 52);
