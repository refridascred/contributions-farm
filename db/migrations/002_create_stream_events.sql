-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, label, count, ratio) VALUES ('staging', 'strict', 0, 81.96);
INSERT INTO stream_events (owner, label, count, ratio) VALUES ('green', 'eu-west', 7, 80.2);
INSERT INTO stream_events (owner, label, count, ratio) VALUES ('open', 'local', 60, 44.68);
