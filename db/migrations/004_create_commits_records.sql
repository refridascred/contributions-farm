-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (rank, active, score, level) VALUES (38, 37, 92.02, 59);
INSERT INTO commits_records (rank, active, score, level) VALUES (83, 74, 52.91, 32);
INSERT INTO commits_records (rank, active, score, level) VALUES (64, 12, 74.51, 45);
