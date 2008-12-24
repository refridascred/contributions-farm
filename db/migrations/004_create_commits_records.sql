-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (region, weight, owner, active) VALUES ('eu-west', 60.58, 'eu-west', 83);
INSERT INTO commits_records (region, weight, owner, active) VALUES ('fallback', 71.33, 'strict', 89);
INSERT INTO commits_records (region, weight, owner, active) VALUES ('edge', 80.53, 'primary', 29);
