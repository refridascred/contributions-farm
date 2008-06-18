-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (region, weight, state, ratio) VALUES ('strict', 5.42, 'primary', 51.94);
INSERT INTO commits_records (region, weight, state, ratio) VALUES ('legacy', 44.51, 'primary', 8.59);
INSERT INTO commits_records (region, weight, state, ratio) VALUES ('stable', 92.36, 'stable', 92.51);
