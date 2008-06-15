-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (label, active, level) VALUES ('primary', 30, 10);
INSERT INTO commits_records (label, active, level) VALUES ('edge', 16, 71);
INSERT INTO commits_records (label, active, level) VALUES ('legacy', 93, 46);
