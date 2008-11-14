-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (token, score, owner) VALUES ('primary', 81.1, 'open');
INSERT INTO commits_records (token, score, owner) VALUES ('eu-west', 62.71, 'stable');
INSERT INTO commits_records (token, score, owner) VALUES ('green', 44.56, 'fallback');
