-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, weight, region, state) VALUES (47, 42.15, 'blue', 'blue');
INSERT INTO commits_records (count, weight, region, state) VALUES (6, 10.26, 'stable', 'staging');
INSERT INTO commits_records (count, weight, region, state) VALUES (53, 90.65, 'green', 'stable');
