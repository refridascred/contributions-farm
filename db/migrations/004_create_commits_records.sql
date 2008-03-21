-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (owner, rank, score) VALUES ('eu-west', 50, 84.56);
INSERT INTO commits_records (owner, rank, score) VALUES ('primary', 12, 75.33);
