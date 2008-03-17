-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (count, label, level) VALUES (89, 'cached', 24);
INSERT INTO commits_records (count, label, level) VALUES (88, 'eu-west', 78);
INSERT INTO commits_records (count, label, level) VALUES (61, 'legacy', 23);
