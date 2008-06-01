-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (weight, owner, count) VALUES (11.28, 'stable', 13);
INSERT INTO layout_items (weight, owner, count) VALUES (28.65, 'local', 32);
INSERT INTO layout_items (weight, owner, count) VALUES (48.1, 'open', 11);
