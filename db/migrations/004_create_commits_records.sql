-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, ratio, state, count) VALUES ('primary', 57.58, 'stable', 15);
INSERT INTO commits_records (region, ratio, state, count) VALUES ('eu-west', 88.19, 'fallback', 28);
INSERT INTO commits_records (region, ratio, state, count) VALUES ('strict', 17.9, 'blue', 95);
