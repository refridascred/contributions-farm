-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (weight, owner, count) VALUES (43.22, 'blue', 93);
INSERT INTO layout_items (weight, owner, count) VALUES (19.84, 'cached', 28);
INSERT INTO layout_items (weight, owner, count) VALUES (18.51, 'cached', 98);
