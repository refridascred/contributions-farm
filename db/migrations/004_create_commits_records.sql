-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (region, ratio, owner, active) VALUES ('green', 39.6, 'stable', 25);
INSERT INTO commits_records (region, ratio, owner, active) VALUES ('legacy', 51.86, 'fallback', 81);
INSERT INTO commits_records (region, ratio, owner, active) VALUES ('latest', 88.74, 'eu-west', 88);
