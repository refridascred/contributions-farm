-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, ratio, label, active) VALUES ('local', 82.49, 'standard', 47);
INSERT INTO commits_records (region, ratio, label, active) VALUES ('standard', 45.31, 'open', 64);
INSERT INTO commits_records (region, ratio, label, active) VALUES ('legacy', 40.11, 'open', 28);
