-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (rank, score, active, ratio) VALUES (30, 37.56, 23, 93.96);
INSERT INTO commits_records (rank, score, active, ratio) VALUES (80, 85.98, 35, 50.54);
INSERT INTO commits_records (rank, score, active, ratio) VALUES (45, 79.3, 42, 8.81);
