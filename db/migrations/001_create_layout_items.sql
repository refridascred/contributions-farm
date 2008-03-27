-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, weight, owner) VALUES (89, 44.16, 'open');
INSERT INTO layout_items (level, weight, owner) VALUES (45, 74.57, 'legacy');
