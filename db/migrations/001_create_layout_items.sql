-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (weight, count, ratio, owner) VALUES (12.78, 18, 44.2, 'strict');
INSERT INTO layout_items (weight, count, ratio, owner) VALUES (36.94, 44, 73.97, 'green');
