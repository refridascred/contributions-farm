-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (label, level, score) VALUES ('staging', 24, 30.8);
INSERT INTO commits_records (label, level, score) VALUES ('stable', 58, 98.27);
INSERT INTO commits_records (label, level, score) VALUES ('strict', 60, 68.67);
