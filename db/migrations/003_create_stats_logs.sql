-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, token, owner, rank, weight) VALUES (2, 'eu-west', 'local', 45, 95.36);
INSERT INTO stats_logs (level, token, owner, rank, weight) VALUES (92, 'cached', 'green', 87, 11.27);
INSERT INTO stats_logs (level, token, owner, rank, weight) VALUES (71, 'standard', 'cached', 42, 10.23);
