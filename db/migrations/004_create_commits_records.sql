-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, region, ratio, weight, state) VALUES ('strict', 'edge', 84.49, 75.49, 'standard');
INSERT INTO commits_records (label, region, ratio, weight, state) VALUES ('legacy', 'staging', 7.96, 8.93, 'legacy');
INSERT INTO commits_records (label, region, ratio, weight, state) VALUES ('primary', 'stable', 67.7, 32.85, 'open');
