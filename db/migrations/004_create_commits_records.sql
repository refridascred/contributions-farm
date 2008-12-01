-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (label, level, count) VALUES ('green', 98, 83);
INSERT INTO commits_records (label, level, count) VALUES ('legacy', 13, 94);
INSERT INTO commits_records (label, level, count) VALUES ('eu-west', 90, 49);
