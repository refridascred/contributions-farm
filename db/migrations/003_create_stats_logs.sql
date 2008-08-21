-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (label, owner, count, state) VALUES ('fallback', 'primary', 84, 'eu-west');
INSERT INTO stats_logs (label, owner, count, state) VALUES ('green', 'primary', 6, 'fallback');
