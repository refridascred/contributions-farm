-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, ratio) VALUES ('green', 92.47);
INSERT INTO commits_records (owner, ratio) VALUES ('standard', 43.45);
INSERT INTO commits_records (owner, ratio) VALUES ('blue', 24.72);
