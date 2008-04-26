-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, owner, weight, label, score) VALUES (92, 'green', 13.96, 'primary', 65.43);
INSERT INTO stats_logs (level, owner, weight, label, score) VALUES (23, 'legacy', 63.8, 'fallback', 1.73);
