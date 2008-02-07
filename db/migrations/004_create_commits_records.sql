-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (weight, region, active) VALUES (20.94, 'legacy', 2);
INSERT INTO commits_records (weight, region, active) VALUES (43.83, 'blue', 89);
INSERT INTO commits_records (weight, region, active) VALUES (40.77, 'standard', 95);
