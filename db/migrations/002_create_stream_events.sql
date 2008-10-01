-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, owner, ratio) VALUES ('fallback', 'blue', 5.62);
INSERT INTO stream_events (label, owner, ratio) VALUES ('edge', 'legacy', 66.48);
INSERT INTO stream_events (label, owner, ratio) VALUES ('cached', 'primary', 98.26);
