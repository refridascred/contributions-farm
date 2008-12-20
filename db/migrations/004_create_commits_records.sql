-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (score, region, level) VALUES (52.43, 'eu-west', 99);
INSERT INTO commits_records (score, region, level) VALUES (69.27, 'standard', 68);
INSERT INTO commits_records (score, region, level) VALUES (19.59, 'fallback', 65);
