-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (owner, weight, rank, level) VALUES ('blue', 62.46, 61, 85);
INSERT INTO stats_logs (owner, weight, rank, level) VALUES ('staging', 28.15, 43, 4);
