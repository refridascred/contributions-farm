-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (state, rank, score, ratio) VALUES ('legacy', 52, 19.22, 24.99);
INSERT INTO stats_logs (state, rank, score, ratio) VALUES ('latest', 15, 60.39, 45.05);
INSERT INTO stats_logs (state, rank, score, ratio) VALUES ('strict', 78, 21.87, 12.27);
