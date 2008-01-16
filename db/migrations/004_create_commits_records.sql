-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    level INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (rank, token, level, label, active) VALUES (52, 'cached', 58, 'open', 91);
INSERT INTO commits_records (rank, token, level, label, active) VALUES (73, 'staging', 36, 'blue', 25);
INSERT INTO commits_records (rank, token, level, label, active) VALUES (38, 'stable', 59, 'open', 17);
