-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (owner, level, label, weight) VALUES ('blue', 96, 'strict', 98.22);
INSERT INTO stats_logs (owner, level, label, weight) VALUES ('primary', 16, 'open', 73.4);
INSERT INTO stats_logs (owner, level, label, weight) VALUES ('strict', 3, 'legacy', 73.63);
