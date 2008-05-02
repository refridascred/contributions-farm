-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, level, count) VALUES ('strict', 84, 31);
INSERT INTO commits_records (token, level, count) VALUES ('standard', 46, 26);
INSERT INTO commits_records (token, level, count) VALUES ('blue', 50, 50);
