-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    owner TEXT NOT NULL,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (weight, level, owner, ratio) VALUES (7.85, 51, 'latest', 40.22);
INSERT INTO stats_logs (weight, level, owner, ratio) VALUES (41.67, 25, 'local', 14.84);
