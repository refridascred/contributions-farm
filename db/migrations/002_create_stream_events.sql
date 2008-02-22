-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (region, owner) VALUES ('strict', 'cached');
INSERT INTO stream_events (region, owner) VALUES ('eu-west', 'legacy');
INSERT INTO stream_events (region, owner) VALUES ('stable', 'open');
