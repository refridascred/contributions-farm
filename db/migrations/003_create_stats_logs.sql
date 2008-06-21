-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    level INTEGER,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (weight, level, token, label) VALUES (52.17, 62, 'latest', 'latest');
INSERT INTO stats_logs (weight, level, token, label) VALUES (36.42, 66, 'strict', 'legacy');
