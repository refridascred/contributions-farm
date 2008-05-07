-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (label, rank, active) VALUES ('green', 64, 96);
INSERT INTO commits_records (label, rank, active) VALUES ('eu-west', 93, 78);
INSERT INTO commits_records (label, rank, active) VALUES ('blue', 13, 84);
