-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (region, label, owner) VALUES ('legacy', 'fallback', 'staging');
INSERT INTO stream_events (region, label, owner) VALUES ('staging', 'cached', 'strict');
INSERT INTO stream_events (region, label, owner) VALUES ('open', 'staging', 'strict');
