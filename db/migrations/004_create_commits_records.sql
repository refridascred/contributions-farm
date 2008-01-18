-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, owner, score, token) VALUES (15.0, 'local', 18.34, 'primary');
INSERT INTO commits_records (weight, owner, score, token) VALUES (67.55, 'stable', 78.76, 'legacy');
