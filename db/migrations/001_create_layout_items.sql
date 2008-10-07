-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, count, ratio, score, rank) VALUES ('stable', 57, 43.93, 22.23, 39);
