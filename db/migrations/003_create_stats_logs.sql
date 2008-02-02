-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (owner, level, rank) VALUES ('green', 89, 91);
INSERT INTO stats_logs (owner, level, rank) VALUES ('cached', 35, 99);
INSERT INTO stats_logs (owner, level, rank) VALUES ('primary', 76, 26);
