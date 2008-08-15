-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (owner, score, count) VALUES ('staging', 46.18, 84);
INSERT INTO layout_items (owner, score, count) VALUES ('edge', 89.2, 80);
INSERT INTO layout_items (owner, score, count) VALUES ('eu-west', 81.1, 24);
