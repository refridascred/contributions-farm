-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, ratio, label, region) VALUES (21.2, 69.65, 'standard', 'latest');
INSERT INTO commits_records (score, ratio, label, region) VALUES (7.01, 43.74, 'eu-west', 'legacy');
