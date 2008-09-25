-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (label, owner, level) VALUES ('strict', 'strict', 31);
INSERT INTO stream_events (label, owner, level) VALUES ('fallback', 'eu-west', 68);
INSERT INTO stream_events (label, owner, level) VALUES ('legacy', 'legacy', 94);
