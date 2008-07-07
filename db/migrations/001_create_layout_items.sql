-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, weight, owner) VALUES (32, 21.39, 'strict');
INSERT INTO layout_items (count, weight, owner) VALUES (47, 49.02, 'local');
INSERT INTO layout_items (count, weight, owner) VALUES (7, 83.98, 'open');
