-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (owner, level, token, ratio) VALUES ('cached', 30, 'open', 79.69);
INSERT INTO stats_logs (owner, level, token, ratio) VALUES ('blue', 92, 'standard', 86.54);
INSERT INTO stats_logs (owner, level, token, ratio) VALUES ('open', 92, 'legacy', 25.4);
