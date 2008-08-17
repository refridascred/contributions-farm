-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (count, level, active) VALUES (53, 31, 73);
INSERT INTO commits_records (count, level, active) VALUES (91, 12, 39);
INSERT INTO commits_records (count, level, active) VALUES (77, 95, 53);
