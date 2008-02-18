-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, weight, token) VALUES (38.54, 96.56, 'primary');
INSERT INTO commits_records (score, weight, token) VALUES (33.64, 6.8, 'staging');
