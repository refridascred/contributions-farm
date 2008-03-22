-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (score, owner, count) VALUES (32.17, 'open', 73);
INSERT INTO layout_items (score, owner, count) VALUES (26.13, 'edge', 16);
INSERT INTO layout_items (score, owner, count) VALUES (59.53, 'edge', 89);
