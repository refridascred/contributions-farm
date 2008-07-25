-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (weight, owner, level) VALUES (59.88, 'latest', 24);
INSERT INTO stats_logs (weight, owner, level) VALUES (18.5, 'cached', 18);
INSERT INTO stats_logs (weight, owner, level) VALUES (98.11, 'local', 29);
