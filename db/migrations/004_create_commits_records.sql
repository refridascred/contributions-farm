-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (region, label, count, level) VALUES ('eu-west', 'local', 34, 84);
INSERT INTO commits_records (region, label, count, level) VALUES ('cached', 'legacy', 73, 59);
INSERT INTO commits_records (region, label, count, level) VALUES ('green', 'primary', 80, 19);
