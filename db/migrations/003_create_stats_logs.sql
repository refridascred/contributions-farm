-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (score, label, level) VALUES (1.58, 'eu-west', 81);
INSERT INTO stats_logs (score, label, level) VALUES (15.18, 'local', 19);
INSERT INTO stats_logs (score, label, level) VALUES (73.77, 'blue', 37);
