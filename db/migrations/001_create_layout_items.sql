-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (count, owner, weight, rank) VALUES (28, 'fallback', 45.67, 72);
INSERT INTO layout_items (count, owner, weight, rank) VALUES (96, 'standard', 77.71, 43);
