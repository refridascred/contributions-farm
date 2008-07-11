-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (owner, label, level, weight) VALUES ('local', 'primary', 84, 46.08);
INSERT INTO stream_events (owner, label, level, weight) VALUES ('primary', 'local', 79, 16.51);
INSERT INTO stream_events (owner, label, level, weight) VALUES ('eu-west', 'latest', 78, 11.74);
