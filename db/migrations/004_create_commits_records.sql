-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (score, weight) VALUES (73.94, 12.08);
INSERT INTO commits_records (score, weight) VALUES (55.09, 75.41);
INSERT INTO commits_records (score, weight) VALUES (80.34, 23.71);
