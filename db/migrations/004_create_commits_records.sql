-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (region, active, score, rank, weight) VALUES ('blue', 89, 46.3, 86, 89.63);
INSERT INTO commits_records (region, active, score, rank, weight) VALUES ('cached', 25, 93.18, 16, 60.47);
INSERT INTO commits_records (region, active, score, rank, weight) VALUES ('edge', 76, 93.17, 55, 11.4);
