-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (token, level, active, count) VALUES ('latest', 7, 52, 4);
INSERT INTO commits_records (token, level, active, count) VALUES ('legacy', 66, 15, 78);
INSERT INTO commits_records (token, level, active, count) VALUES ('cached', 19, 43, 13);
