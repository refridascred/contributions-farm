-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (owner, active, label, level, ratio) VALUES ('legacy', 33, 'eu-west', 13, 58.14);
INSERT INTO stats_logs (owner, active, label, level, ratio) VALUES ('blue', 83, 'fallback', 18, 22.62);
INSERT INTO stats_logs (owner, active, label, level, ratio) VALUES ('strict', 53, 'edge', 48, 8.67);
