-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (owner, count, label, level, state) VALUES ('eu-west', 36, 'latest', 25, 'edge');
INSERT INTO stats_logs (owner, count, label, level, state) VALUES ('staging', 2, 'fallback', 79, 'fallback');
