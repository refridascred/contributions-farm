-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (weight, owner, count, ratio) VALUES (30.9, 'blue', 32, 73.42);
INSERT INTO layout_items (weight, owner, count, ratio) VALUES (94.15, 'eu-west', 32, 34.04);
