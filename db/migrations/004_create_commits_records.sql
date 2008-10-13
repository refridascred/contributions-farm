-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    region TEXT,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (active, owner, region, weight) VALUES (33, 'stable', 'open', 5.62);
INSERT INTO commits_records (active, owner, region, weight) VALUES (59, 'open', 'green', 51.9);
INSERT INTO commits_records (active, owner, region, weight) VALUES (50, 'legacy', 'strict', 70.01);
