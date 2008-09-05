-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    owner TEXT NOT NULL,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (ratio, owner, token, weight) VALUES (78.96, 'blue', 'legacy', 44.89);
INSERT INTO commits_records (ratio, owner, token, weight) VALUES (78.71, 'latest', 'eu-west', 31.31);
INSERT INTO commits_records (ratio, owner, token, weight) VALUES (4.72, 'legacy', 'edge', 75.92);
