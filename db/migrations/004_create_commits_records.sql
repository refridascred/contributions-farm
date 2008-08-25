-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (level, region, score) VALUES (55, 'legacy', 5.79);
INSERT INTO commits_records (level, region, score) VALUES (87, 'fallback', 37.94);
INSERT INTO commits_records (level, region, score) VALUES (75, 'standard', 98.18);
