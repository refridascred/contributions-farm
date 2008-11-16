-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, token, rank) VALUES (37.84, 'standard', 93);
INSERT INTO commits_records (score, token, rank) VALUES (6.86, 'eu-west', 6);
INSERT INTO commits_records (score, token, rank) VALUES (82.21, 'latest', 53);
