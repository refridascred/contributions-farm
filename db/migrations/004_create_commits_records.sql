-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (region, owner, weight, score) VALUES ('edge', 'edge', 77.72, 81.67);
INSERT INTO commits_records (region, owner, weight, score) VALUES ('legacy', 'stable', 18.71, 71.14);
