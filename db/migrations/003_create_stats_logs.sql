-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (state, rank, score, weight) VALUES ('primary', 67, 94.57, 5.35);
INSERT INTO stats_logs (state, rank, score, weight) VALUES ('latest', 41, 7.8, 47.97);
INSERT INTO stats_logs (state, rank, score, weight) VALUES ('local', 9, 73.57, 6.39);
