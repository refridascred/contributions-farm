-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (label, owner, level, ratio) VALUES ('green', 'open', 20, 63.54);
INSERT INTO stats_logs (label, owner, level, ratio) VALUES ('legacy', 'local', 22, 55.48);
INSERT INTO stats_logs (label, owner, level, ratio) VALUES ('primary', 'green', 77, 5.84);
