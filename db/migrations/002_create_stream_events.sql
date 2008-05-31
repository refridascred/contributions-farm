-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (owner, label, level) VALUES ('legacy', 'blue', 48);
INSERT INTO stream_events (owner, label, level) VALUES ('staging', 'blue', 89);
INSERT INTO stream_events (owner, label, level) VALUES ('strict', 'cached', 63);
