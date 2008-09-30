-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (token, level, score) VALUES ('legacy', 58, 60.19);
INSERT INTO commits_records (token, level, score) VALUES ('blue', 20, 70.17);
INSERT INTO commits_records (token, level, score) VALUES ('cached', 81, 69.83);
