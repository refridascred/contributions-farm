-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    label TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (region, ratio, label, weight, state) VALUES ('edge', 1.1, 'standard', 43.99, 'cached');
INSERT INTO commits_records (region, ratio, label, weight, state) VALUES ('local', 26.05, 'stable', 5.1, 'local');
