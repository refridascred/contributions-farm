-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (state, score, rank) VALUES ('primary', 87.59, 85);
INSERT INTO stats_logs (state, score, rank) VALUES ('primary', 40.71, 27);
INSERT INTO stats_logs (state, score, rank) VALUES ('local', 78.88, 41);
