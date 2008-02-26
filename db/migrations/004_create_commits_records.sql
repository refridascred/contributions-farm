-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (token, level) VALUES ('green', 4);
INSERT INTO commits_records (token, level) VALUES ('legacy', 52);
INSERT INTO commits_records (token, level) VALUES ('green', 95);
