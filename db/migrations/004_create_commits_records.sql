-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, weight, region, state) VALUES ('strict', 73.42, 'edge', 'cached');
INSERT INTO commits_records (owner, weight, region, state) VALUES ('local', 2.44, 'primary', 'primary');
INSERT INTO commits_records (owner, weight, region, state) VALUES ('stable', 12.15, 'green', 'open');
