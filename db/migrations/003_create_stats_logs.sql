-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (state, ratio, owner, score) VALUES ('primary', 37.35, 'local', 51.3);
INSERT INTO stats_logs (state, ratio, owner, score) VALUES ('staging', 33.43, 'fallback', 58.44);
INSERT INTO stats_logs (state, ratio, owner, score) VALUES ('edge', 64.19, 'strict', 31.84);
