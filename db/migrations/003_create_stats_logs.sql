-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (state, rank, score, weight) VALUES ('latest', 98, 75.98, 81.5);
INSERT INTO stats_logs (state, rank, score, weight) VALUES ('legacy', 5, 35.02, 67.76);
INSERT INTO stats_logs (state, rank, score, weight) VALUES ('primary', 52, 54.68, 49.43);
