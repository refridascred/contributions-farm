-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (region, owner, score) VALUES ('standard', 'green', 60.06);
INSERT INTO commits_records (region, owner, score) VALUES ('blue', 'legacy', 71.33);
INSERT INTO commits_records (region, owner, score) VALUES ('legacy', 'staging', 24.56);
