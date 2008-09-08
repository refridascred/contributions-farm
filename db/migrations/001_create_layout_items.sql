-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, rank, count, score, label) VALUES ('local', 35, 7, 63.71, 'primary');
INSERT INTO layout_items (owner, rank, count, score, label) VALUES ('open', 41, 35, 77.37, 'green');
INSERT INTO layout_items (owner, rank, count, score, label) VALUES ('edge', 90, 62, 1.09, 'local');
