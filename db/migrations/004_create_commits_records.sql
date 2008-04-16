-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, label, region, active) VALUES (87.84, 'green', 'cached', 99);
INSERT INTO commits_records (weight, label, region, active) VALUES (23.36, 'stable', 'edge', 85);
INSERT INTO commits_records (weight, label, region, active) VALUES (38.14, 'primary', 'legacy', 67);
