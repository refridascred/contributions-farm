-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (label, count, level) VALUES ('open', 54, 97);
INSERT INTO commits_records (label, count, level) VALUES ('open', 67, 90);
INSERT INTO commits_records (label, count, level) VALUES ('standard', 40, 65);
