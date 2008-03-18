-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, owner, ratio) VALUES ('strict', 'primary', 16.68);
INSERT INTO stream_events (label, owner, ratio) VALUES ('eu-west', 'strict', 7.96);
INSERT INTO stream_events (label, owner, ratio) VALUES ('edge', 'strict', 77.66);
