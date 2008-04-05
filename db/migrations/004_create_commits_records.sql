-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    ratio REAL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, ratio, weight, count) VALUES ('blue', 26.68, 94.38, 96);
INSERT INTO commits_records (region, ratio, weight, count) VALUES ('primary', 94.77, 1.12, 89);
INSERT INTO commits_records (region, ratio, weight, count) VALUES ('cached', 89.79, 79.35, 71);
