-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, token, score, level, weight) VALUES ('strict', 'latest', 50.11, 14, 60.18);
INSERT INTO stats_logs (owner, token, score, level, weight) VALUES ('blue', 'primary', 90.08, 63, 7.26);
