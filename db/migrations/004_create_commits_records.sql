-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, active, token, score, weight) VALUES (34, 91, 'eu-west', 74.46, 58.95);
INSERT INTO commits_records (level, active, token, score, weight) VALUES (78, 62, 'stable', 96.3, 36.5);
INSERT INTO commits_records (level, active, token, score, weight) VALUES (22, 31, 'staging', 4.35, 81.43);
