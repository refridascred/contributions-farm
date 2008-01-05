-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, region, label, level) VALUES (13.65, 'legacy', 'legacy', 51);
INSERT INTO commits_records (score, region, label, level) VALUES (45.55, 'open', 'strict', 60);
INSERT INTO commits_records (score, region, label, level) VALUES (12.49, 'staging', 'stable', 11);
