-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, owner, level, rank) VALUES ('staging', 'stable', 9, 12);
INSERT INTO commits_records (label, owner, level, rank) VALUES ('local', 'stable', 8, 26);
