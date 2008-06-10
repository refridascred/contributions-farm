-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (ratio, level, score) VALUES (9.68, 49, 96.57);
INSERT INTO commits_records (ratio, level, score) VALUES (73.67, 15, 83.75);
INSERT INTO commits_records (ratio, level, score) VALUES (95.79, 67, 85.07);
