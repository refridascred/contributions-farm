-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (owner, score, weight, level) VALUES ('cached', 18.35, 77.63, 31);
INSERT INTO stats_logs (owner, score, weight, level) VALUES ('eu-west', 72.86, 9.41, 80);
INSERT INTO stats_logs (owner, score, weight, level) VALUES ('latest', 11.43, 29.43, 32);
