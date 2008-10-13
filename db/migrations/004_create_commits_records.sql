-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (level, label, rank, score) VALUES (44, 'legacy', 62, 35.84);
INSERT INTO commits_records (level, label, rank, score) VALUES (95, 'latest', 45, 3.34);
