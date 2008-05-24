-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, active, rank, level) VALUES ('open', 10, 80, 74);
INSERT INTO commits_records (label, active, rank, level) VALUES ('cached', 19, 35, 75);
INSERT INTO commits_records (label, active, rank, level) VALUES ('eu-west', 54, 96, 41);
