-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (owner, ratio, level, score, active) VALUES ('cached', 10.43, 57, 97.54, 71);
INSERT INTO commits_records (owner, ratio, level, score, active) VALUES ('blue', 39.02, 17, 83.82, 77);
