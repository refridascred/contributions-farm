-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (level, region, weight) VALUES (97, 'stable', 71.7);
INSERT INTO commits_records (level, region, weight) VALUES (40, 'cached', 42.53);
INSERT INTO commits_records (level, region, weight) VALUES (83, 'local', 86.88);
