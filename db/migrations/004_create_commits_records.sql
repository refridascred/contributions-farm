-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (weight, region, active) VALUES (93.53, 'cached', 84);
INSERT INTO commits_records (weight, region, active) VALUES (70.07, 'open', 65);
INSERT INTO commits_records (weight, region, active) VALUES (60.2, 'stable', 50);
