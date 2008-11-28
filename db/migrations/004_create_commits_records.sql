-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (region, rank, score, active) VALUES ('primary', 10, 35.9, 64);
INSERT INTO commits_records (region, rank, score, active) VALUES ('open', 88, 26.01, 3);
INSERT INTO commits_records (region, rank, score, active) VALUES ('legacy', 3, 15.1, 54);
