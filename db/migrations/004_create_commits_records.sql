-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (region, score, level, label) VALUES ('local', 55.25, 20, 'stable');
INSERT INTO commits_records (region, score, level, label) VALUES ('staging', 44.4, 82, 'cached');
INSERT INTO commits_records (region, score, level, label) VALUES ('latest', 40.12, 83, 'fallback');
