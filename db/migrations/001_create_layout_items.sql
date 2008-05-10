-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, ratio, owner, count, label) VALUES (27.71, 26.84, 'edge', 21, 'staging');
INSERT INTO layout_items (weight, ratio, owner, count, label) VALUES (16.07, 84.4, 'standard', 69, 'blue');
INSERT INTO layout_items (weight, ratio, owner, count, label) VALUES (1.17, 34.53, 'primary', 44, 'edge');
