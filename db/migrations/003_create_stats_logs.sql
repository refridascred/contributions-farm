-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (state, score, region, owner, ratio) VALUES ('cached', 77.35, 'green', 'strict', 43.42);
INSERT INTO stats_logs (state, score, region, owner, ratio) VALUES ('primary', 1.11, 'blue', 'staging', 80.21);
INSERT INTO stats_logs (state, score, region, owner, ratio) VALUES ('primary', 53.66, 'eu-west', 'staging', 3.65);
